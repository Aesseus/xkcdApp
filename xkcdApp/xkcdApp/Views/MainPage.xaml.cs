using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;
using xkcdApp.Core;

namespace xkcdApp.Views
{
    public partial class MainPage : ContentPage
    {
        public ICommand SaveCommand { get; }

        public MainPage()
        {
            InitializeComponent();

            SaveCommand = new AsyncCommand(() => OnSave(), allowsMultipleExecutions: false);
        }

        private async Task OnSave()
        {
            // Perform save
        }
    }
}
