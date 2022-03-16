using GalloStore.Models;
using GalloStore.ViewModels;
using GalloStore.Views;
using MonkeyCache.FileStore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace GalloStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]


    public partial class CatalogoPage : ContentPage
    {
       // public Command AgregarCommand => new Command(async () => { await AgregarSync(); });


        Command _AgregarCommand;
        public Command AgregarCommand => _AgregarCommand ?? 
            (_AgregarCommand = new Command(AgregarSync));

        //private async Task AgregarSync()
        //{
        //    var select = colletion.SelectedItem;
        //    var selects = colletion.SelectedItems;
        //    await DisplayAlert("test", "asfa","Cancel");
        //}

        private void  AgregarSync(object obj)
        {
            var url = "catalogo";
            var catalogo = new List<Catalogo>();
            catalogo.Add((Catalogo)obj);

            Barrel.Current.Add(key: url, data: catalogo, expireIn: TimeSpan.FromDays(200));
        }
        public CatalogoPage()
        {
            InitializeComponent();
            this.BindingContext = new CatalogoViewModel();



        }

        private void TapMenos_Tapped(object sender, EventArgs e)
        {
           
        }

        private void TapMas_Tapped(object sender, EventArgs e)
        {

        }
    }
}