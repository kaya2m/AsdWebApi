using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Autofac;
using Microsoft.EntityFrameworkCore;
using Persistence.DB;
using Repository.Service;
using Repository.UnitOfwork;
using System.Reflection;
using Module = Autofac.Module;

namespace Repository.Repositories
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<MailService>().As<IMailService>()
            //    .InstancePerRequest();

            //builder.RegisterType<AuthenticationService>().As<IAuthenticationService>()
            //    .InstancePerRequest();

            // Register DbContext with the appropriate lifetime
            builder.RegisterType<AsdDbContext>()
                .As<DbContext>()
                .InstancePerLifetimeScope();

            // Register UnitOfWork
            builder.RegisterType<UnitOfwork.UnitOfwork>().As<IUnitOfWork>()
                .InstancePerLifetimeScope();

            // Register GenericRepository and GenericService
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>))
                .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>))
                .InstancePerLifetimeScope();

            // Register repository and service assemblies
            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(AsdDbContext));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly)
                .Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
