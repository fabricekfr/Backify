using GalaSoft.MvvmLight;

namespace Presentation
{

    public class MainWindowViewModel : ViewModelBase
    {
        private string _welcomeTitle = "Sci chart magic";
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                Set(ref _welcomeTitle, value);
            }
        }
    }
}