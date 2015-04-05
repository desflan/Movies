using Autofac;
using Autofac.Extras.AggregateService;
using Autofac.Extras.DynamicProxy2;
using MovieSite.Data.Infrastructure;
using MovieSite.Services.Interfaces;

namespace MovieSite.Services.Infrastructure
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ProfileInterceptor>();

            builder.RegisterAssemblyTypes(ThisAssembly)
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces()
                   .EnableInterfaceInterceptors()
                   .InterceptedBy(typeof(ProfileInterceptor));

            builder.RegisterAggregateService<IServices>();

            base.Load(builder);
        }
    }
}
