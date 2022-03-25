using GalloStore.ViewModels;
using MonkeyCache.FileStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GalloStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogoutPage : ContentPage
    {
        
        public LogoutPage()
        {
            InitializeComponent();
            
            this.BindingContext = new LogoutViewModel();

           
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();


        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            Barrel.Current.EmptyAll();
            App.Current.MainPage = new BienvenidaPage();
        }
    }
}