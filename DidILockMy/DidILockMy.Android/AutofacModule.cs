using Autofac;
using DidILockMy.Droid.Providers;

namespace DidILockMy.Droid
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