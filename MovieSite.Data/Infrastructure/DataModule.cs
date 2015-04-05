using Autofac;
using Autofac.Extras.DynamicProxy2;
using MoviesLibrary;

namespace MovieSite.Data.Infrastructure
{
    class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           builder.RegisterType<ProfileInterceptor>();

            builder.RegisterType<MovieDataSource>();

            builder.RegisterType<Kaching>().As<IKaching>().SingleInstance();

            builder.RegisterAssemblyTypes(ThisAssembly)
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces()
                   .EnableInterfaceInterceptors()
               .InterceptedBy(typeof(ProfileInterceptor));

            base.Load(builder);
        }
    }
}
