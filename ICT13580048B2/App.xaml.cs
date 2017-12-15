using ICT13580048B2.Helpers;
using Xamarin.Forms;

namespace ICT13580048B2
{
    public partial class App : Application
    {
        public static DbHelper Dbhelper{get;set;}
        public App()
        {
            InitializeComponent();
        }

        public App(string dbPath)
        {
            InitializeComponent();

            Dbhelper = new DbHelper(dbPath);

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
