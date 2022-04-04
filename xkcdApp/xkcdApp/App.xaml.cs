using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xkcdApp.Views;

namespace xkcdApp
{
    public partial class App : Application
    {
        internal const string WEATHER_API_KEY = "";

        public App()
        {
            InitializeComponent();

            Core.ApiHelper.InitializeClient();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
