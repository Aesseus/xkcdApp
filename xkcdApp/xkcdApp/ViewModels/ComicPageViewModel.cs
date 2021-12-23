using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;
using xkcdApp.Core;
using xkcdApp.Models;

namespace xkcdApp.ViewModels
{
    public class ComicPageViewModel : Core.ObservableObject
    {
        private ComicModel comicModel;
        private int currentComicNumber = 2556;

        public ComicModel ComicModel
        {
            get => comicModel;
            set
            {
                comicModel = value;
                OnPropertyChanged();
            }
        }

        public AsyncCommand NextCommand { get; }
        public AsyncCommand PreviousCommand { get; }

        public ComicPageViewModel()
        {
            NextCommand = new AsyncCommand(() => LoadNextComic(+1), () => currentComicNumber < 2556);
            PreviousCommand = new AsyncCommand(() => LoadNextComic(-1), () => currentComicNumber > 0);
        }

        private async Task LoadNextComic(int change)
        {
            currentComicNumber += change;

            LoadComic loadComic = new LoadComic();
            ComicModel = await loadComic.NextComic(currentComicNumber);

            NextCommand.RaiseCanExecuteChanged();
            PreviousCommand.RaiseCanExecuteChanged();
        }
    }
}
