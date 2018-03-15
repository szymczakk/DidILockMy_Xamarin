using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using Autofac.Core;
using Xamarin.Forms;

namespace DidILockMy
{
	public partial class App : Application
	{
        private static IContainer _container;

        public App ()
		{
			InitializeComponent();

			MainPage = new DidILockMy.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        private static void PrepareContainer(IModule[] platformSpecificModules)
        {
            var containerBuilder = new Autofac.ContainerBuilder();
            RegisterPlatformSpecificModules(platformSpecificModules, containerBuilder);
            containerBuilder.RegisterType<TrackingsDatabase>().SingleInstance();
            _container = containerBuilder.Build();
        }

        private static void RegisterPlatformSpecificModules(IModule[] platformSpecificModules, ContainerBuilder containerBuilder)
        {
            foreach (var platformSpecificModule in platformSpecificModules)
            {
                containerBuilder.RegisterModule(platformSpecificModule);
            }
        }
    }
}
