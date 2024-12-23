using Application.Repositories;
using Application.Services;
using Application.UnitOfWork;
using Autofac;
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

            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>))
                .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>))
                .InstancePerLifetimeScope();


            builder.RegisterType<UnitOfwork.UnitOfwork>().As<IUnitOfWork>()
                .InstancePerLifetimeScope();

            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(AsdDbContext ));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly)
                .Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
