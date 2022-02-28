using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using xkcdApp.Views;

namespace xkcdApp.ViewModels
{
    public class MainPageViewModel : Core.ObservableObject
    {
        public ICommand ComicCommand { get; }

        public MainPageViewModel()
        {
            ComicCommand = new AsyncCommand(() => ShowComic());
        }

        private Task ShowComic()
        {
            return App.Current.MainPage.Navigation.PushAsync(new ComicViewPage());
        }
    }
}
