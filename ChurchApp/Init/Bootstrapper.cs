using ChurchApp.Services;
using ChurchApp.ViewModels;
using CommonServiceLocator;
using Unity;
using Unity.Lifetime;
using Unity.ServiceLocation;

namespace ChurchApp.Init
{
    public class Bootstrapper
    {
        public static void RegisterDependencies()
        {
            var container = new UnityContainer();

            // service
            container.RegisterType<WordpressService>(new ContainerControlledLifetimeManager());

            // viewmodel
            container.RegisterType<PostViewModel>(new ContainerControlledLifetimeManager());
            container.RegisterType<KingViewModel>(new ContainerControlledLifetimeManager());
            container.RegisterType<SettingsViewModel>(new ContainerControlledLifetimeManager());
            container.RegisterType<QueenViewModel>(new ContainerControlledLifetimeManager());
            container.RegisterType<CouplesViewModel>(new ContainerControlledLifetimeManager());
            container.RegisterType<SinglesViewModel>(new ContainerControlledLifetimeManager());
            container.RegisterType<HomeViewModel>(new ContainerControlledLifetimeManager());

            var locator = new UnityServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => locator);
        }
    }
}
