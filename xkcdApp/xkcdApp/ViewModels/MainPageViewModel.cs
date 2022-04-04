using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using xkcdApp.Core;
using xkcdApp.Views;

namespace xkcdApp.ViewModels
{
    public class MainPageViewModel : ObserverbleObject
    {
        public Command OpenComicCommand { get; set; }
        

        public MainPageViewModel()
        {
            OpenComicCommand = new Command(() => App.Current.MainPage.Navigation.PushAsync(new ComicPage()));
            
         
        }

       /* protected void OnOpenWeather(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new WeatherPage());
        } */
    }
}
