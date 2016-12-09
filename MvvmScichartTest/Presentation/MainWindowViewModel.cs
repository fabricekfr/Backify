using GalaSoft.MvvmLight;

namespace Presentation
{

    public class MainWindowViewModel : ViewModelBase
    {
        private string _welcomeTitle = "WelcomeTitle";
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