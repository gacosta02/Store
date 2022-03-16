using GalloStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GalloStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            this.BindingContext = new HomeViewModel();

            MoverPage.Clicked += (sender, e) =>
            {

                Navigation.PushAsync(new VerMasPrimeraPage());
            };

            VerPage.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new VerMasSegundaPage());
            };

            MostrarPage.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new VerMasTerceraPage());
            };

            Preferences.Set("buzon", true);
        }

  }
}