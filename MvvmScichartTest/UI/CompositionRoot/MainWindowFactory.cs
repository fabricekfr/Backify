using System;
using Castle.Windsor;
using Presentation;

namespace UI.CompositionRoot
{
    public class MainWindowFactory : IMainWindowFactory, IDisposable
    {

        private readonly WindsorContainer _container;
        private bool _disposed;

        public MainWindowFactory()
        {
            _container = new WindsorContainer();
            _container.Install(new ViewModelsInstaller());
        }

        public MainWindow CreateInstance()
        {
            return new MainWindow { DataContext = _container.Resolve<MainWindowViewModel>() };
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing) _container?.Dispose();
            
            _disposed = true;
        }
    }
}