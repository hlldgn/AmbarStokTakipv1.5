using Autofac;

namespace DOGAN.AmbarStokTakip.Business.DependencyResolvers.Autofac
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacBusinessModule());
            IContainer container = builder.Build();
            using (var scope=container.BeginLifetimeScope())
            {
                return scope.Resolve<T>();
            }
        }
    }
}
