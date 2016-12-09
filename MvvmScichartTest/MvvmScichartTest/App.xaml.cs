using System;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight.Threading;
using MvvmScichartTest.CompositionRoot;

namespace MvvmScichartTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
           
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindowFactory = new MainWindowFactory();
            var mainWindow = mainWindowFactory.CreateInstance();

            mainWindow.Show();
        }
    }
}
