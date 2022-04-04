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
    public partial class ComicPage : ContentPage
    {
        public ComicPage()
        {
            InitializeComponent();

            BindingContext = new ComicPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ((ViewModels.ComicPageViewModel)BindingContext).Initialize();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}