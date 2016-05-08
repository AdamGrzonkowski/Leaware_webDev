# Leaware_webDev
## Summary
Fully customized project, written as a test of my programming skills in ASP.NET MVC5.

Take it for a spin by clicking [this](http://leawareweb.azurewebsites.net/) link.

####Functionalities
1. Register / login / logout - works on FormsAuthentication.
2. Viewing products.
3. Cart is being stored in session - lasts until checkout or logout.
4. Adding products to shopping cart (available only for logged in users - if not logged in, it redirects to login page and after successful loggin in, redirects again to calling site).
5. Removing products from shopping cart.
6. Checkout the cart (after order completion, shopping cart is empty).
7. Order completion.
8. List of orders for users with their status.
9. For future use - all carts are being saved in database (even the ones not checked out), with respective dates of their creation.

#### Project structure
Project written in accordance with onion architecture.
* SL.Core - interfaces and domain entities. Independent from rest of solution.
* SL.Models - view models, dbContext and db migrations configuration.
* SL.Repository - implementation of Repository & UnitOfWork design patterns.
* SL.Service - methods of business logic layer.
* SL.Web - startup project. 
* SL.Test - unit tests.

#### IoC
Autofac was used in this project for Inversion of Control. Configuration is as follows:
```C#
public static class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<ApplicationDbContext>().As<ApplicationDbContext>().InstancePerRequest();

            #region Repositories
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterType<UsersRepository>().As<IUsersRepository>().InstancePerRequest();
            ... more repos here ...
            #endregion

            #region Services
            builder.RegisterType<UsersService>().As<IUsersService>().InstancePerRequest();
            ... more services here ...
            #endregion

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
```
#### AutoMapper
This tool provides you with easy mapping of your domain entities to viewmodels and back. Check this out:
First, initialize statically your mappers configuration (recommended approach). You will call Configure() method from your Global.asax.
```C#
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Register, Users>();
                cfg.CreateMap<Login, Users>();
                cfg.CreateMap<Cart, ShoppingCart>();
            });
        }
    }
```
Global.asax
```C#
protected void Application_Start()
        {
            AutoMapperWebConfiguration.Configure();
            ...
        }
```
Usage (maps Register viewModel to Users domain entity):
```C#
var user = Mapper.Map<Register, Users>(model);
```
#### T4MVC
T4MVC was used to simplify calling controller methods. You can read all about this awesome tool on its [github site](https://github.com/T4MVC/T4MVC).
#### Bootstrap
To make site look good on any device, bootstrap was applied to views. Entire application is written on top of standard ASP.NET theme.
