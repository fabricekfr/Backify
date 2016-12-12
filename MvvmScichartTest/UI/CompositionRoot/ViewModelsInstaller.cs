using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Presentation;

namespace UI.CompositionRoot
{
    public class ViewModelsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<MainWindowViewModel>().ImplementedBy<MainWindowViewModel>().LifeStyle.Transient);
        }
    }
}