using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xkcdApp.ViewModels;

namespace xkcdApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComicViewPage : ContentPage
    {
        public ComicViewPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            if (BindingContext is ComicPageViewModel comicPageViewModel)
            {
                await comicPageViewModel.Load();
            }
        }
    }
}