using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xkcdApp.Core;
using xkcdApp.ViewModels;

namespace xkcdApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComicPage : ContentPage
    {             
        public ComicPage()
        {
            InitializeComponent();

            BindingContext = new ComicPageViewModel();

            NavigationPage.SetHasNavigationBar(this, false);

            Entry1.BindingContext = this;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ((ComicPageViewModel)BindingContext).Initialize();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        private async void Entry1_TextChanged(object obj)
        {
            int CurrentComicNumber = 0;
            LoadComic _loadComic = new LoadComic(); 
            CurrentComicNumber = int.Parse(Entry1.Text);
            var result = await _loadComic.NextComic(CurrentComicNumber);
            //if (result != null)
            //{
            //    ImageSource = result.Img;
            //}
        }


    }
}