using GalloStore.ViewModels;
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
    public partial class BienvenidaPage : ContentPage
    {
        public BienvenidaPage()
        {
            InitializeComponent();
            this.BindingContext = new BienvenidaViewModel();

            Acceder.Clicked += (sender, e) =>
            {

               // Navigation.PushAsync(new LoginPage());
                App.Current.MainPage = new LoginPage();
                
            };

            Registrar.Clicked += (sender, e) =>
             {
                // Navigation.PushAsync(new RegistroPage());
                 App.Current.MainPage = new RegistroPage();
             };
        }

        
    }
}