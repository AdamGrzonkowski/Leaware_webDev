﻿using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using SL.Core;
using SL.Core.Interfaces.Repositories;
using SL.Core.Interfaces.UnitOfWork;
using SL.Model;
using SL.Repository.UnitOfWork;
using SL.Repository.Users;
using SL.Repository._Base;

namespace Sklep_Leaware.IoC
{
    public class AutofacConfig
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
            #endregion


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}