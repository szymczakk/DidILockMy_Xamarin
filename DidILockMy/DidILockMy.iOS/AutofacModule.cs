using Autofac;
using DidILockMy.iOS.Providers;

namespace DidILockMy.iOS
{
    public class AutofacModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LocalFilePathProvider>().AsImplementedInterfaces();
            base.Load(builder);
        }
    }
}