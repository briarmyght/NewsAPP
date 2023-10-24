using NewsAPP.pages;
namespace NewsAPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NewsHomePage());
        }
    }
}