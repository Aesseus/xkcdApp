using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using xkcdApp.Core;
using xkcdApp.Views;

namespace xkcdApp.ViewModels
{
    public class ComicPageViewModel : ObserverbleObject
    {
        private LoadComic _loadComic;

        private int _currentComicNumber = 1;

        public int CurrentComicNumber
        {
            get { return _currentComicNumber; }
            set
            {
                _currentComicNumber = value;
                OnPropertyChanged();
            }
        }

        public Command PreviousComicNumber { get; set; }
        public Command NextComicNumber { get; set; }
        Random rnd = new Random();
        public Command RandomComicNumber { get; set; }

        public Command LoadHome { get; set; }
        
        private string _imageSource;

        public string ImageSource
        {
            get { return _imageSource; }
            set
            {
                _imageSource = value;
                OnPropertyChanged();
            }
        }

        public ComicPageViewModel()
        {
            _loadComic = new LoadComic();
            LoadHome = new Command(() => App.Current.MainPage.Navigation.PushAsync(new MainPage()));

            PreviousComicNumber = new Command(OnPreviousComicNumberPressed);
            NextComicNumber = new Command(OnNextComicNumberPressed);

            RandomComicNumber = new Command(OnRandomtComicNumberPressed);
        }

        public void Initialize()
        {
            PreviousComicNumber.Execute(null);
        }

        


        private async void OnNextComicNumberPressed(object obj)
        {
            CurrentComicNumber += 1;
            if (CurrentComicNumber > 2556)
            {
                CurrentComicNumber -= 1;
            }

            var result = await _loadComic.NextComic(CurrentComicNumber);
            if (result != null)
            {
                ImageSource = result.Img;
            }
        }
        private async void OnRandomtComicNumberPressed(object obj)
        {
            CurrentComicNumber = rnd.Next(2556);
            
            var result = await _loadComic.NextComic(CurrentComicNumber);
            if (result != null)
            {
                ImageSource = result.Img;
            }
        }

        private async void OnPreviousComicNumberPressed(object obj)
        {
            CurrentComicNumber -= 1;
            if (CurrentComicNumber <= 0)
            {
                CurrentComicNumber = 1;
            }

            var result = await _loadComic.NextComic(CurrentComicNumber);
            if (result != null)
            {
                ImageSource = result.Img;
            }
        }
    }
}
