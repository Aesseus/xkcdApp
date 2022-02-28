using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xkcdApp.Core;
using xkcdApp.Views;

namespace xkcdApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();

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
