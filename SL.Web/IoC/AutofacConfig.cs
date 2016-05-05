using System;
using System.Linq;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using SL.Core;
using SL.Core.Interfaces.Repositories;
using SL.Core.Interfaces.Repositories.Orders;
using SL.Core.Interfaces.Repositories.Products;
using SL.Core.Interfaces.Repositories.Users;
using SL.Core.Interfaces.Repositories._Base;
using SL.Core.Interfaces.Services;
using SL.Core.Interfaces.Services.Orders;
using SL.Core.Interfaces.Services.Products;
using SL.Core.Interfaces.Services.Users;
using SL.Core.Interfaces.UnitOfWork;
using SL.Model;
using SL.Model.Models.Users;
using SL.Repository.Repositories.Orders;
using SL.Repository.Repositories.Products;
using SL.Repository.Repositories.Users;
using SL.Repository.Repositories._Base;
using SL.Repository.UnitOfWork;
using SL.Service.Orders;
using SL.Service.Products;
using SL.Service.Users;

namespace Sklep_Leaware.IoC
{
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
            builder.RegisterType<BooksRepository>().As<IBooksRepository>().InstancePerRequest();
            builder.RegisterType<CartRepository>().As<ICartRepository>().InstancePerRequest();
            builder.RegisterType<OrderDetailRepository>().As<IOrderDetailRepository>().InstancePerRequest();
            builder.RegisterType<OrdersRepository>().As<IOrdersRepository>().InstancePerRequest();
            #endregion

            #region Services
            builder.RegisterType<UsersService>().As<IUsersService>().InstancePerRequest();
            builder.RegisterType<BooksService>().As<IBooksService>().InstancePerRequest();
            builder.RegisterType<CartService>().As<ICartService>().InstancePerRequest();
            #endregion

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}