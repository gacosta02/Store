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

        

        

        private void  AgregarSync(object obj)
        {
            var url = "catalogo";
            var catalogo = new List<Catalogo>();
            catalogo.Add((Catalogo)obj);
            
            var result = Barrel.Current.Get<List<Catalogo>>(key: url);
            if (result== null)
            {
                Barrel.Current.Add(key: url, data: catalogo, expireIn: TimeSpan.FromDays(200));
                return;
            }
            result.Add((Catalogo)obj);
            DisplayAlert("Agregar", "Producto Agregado satisfactoriamente", "ok");
            Barrel.Current.Add(key: url, data: result, expireIn: TimeSpan.FromDays(200));
        }
        public CatalogoPage()
        {
            InitializeComponent();
            this.BindingContext = new CatalogoViewModel();



        }

       

        //private void TapMas_Tapped(object sender, EventArgs e)
        //{

        //}

        //private void TapMenos_Tapped(object sender, EventArgs e)
        //{

        //}
    }
}