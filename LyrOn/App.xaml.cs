using LyrOn.Classes;
using Xamarin.Forms;

namespace LyrOn
{
    public partial class App : Application
    {
        public static Songs songs = new Songs();

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LyrOnPage());
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
