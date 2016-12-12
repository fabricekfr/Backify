using System.Windows;
using UI.CompositionRoot;

namespace UI
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
