using GalloStore.Models;
using GalloStore.ViewModels;
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
    public partial class CarritoPage : ContentPage
    {
        Command _EliminarCommand;

        public Command EliminarCommand => _EliminarCommand ??
            (_EliminarCommand = new Command(EliminarSync));


        public int PriceCalculator { get; set; } = 0;
        public ObservableCollection<Catalogo> catalogo { get; set; }
        public CarritoPage()
        {
            InitializeComponent();
           // this.BindingContext = new CarritoViewModel();
            Barrel.ApplicationId = "store";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CargarData();
            CargarTotal();
        }

        private void EliminarSync(object obj)
        {
            var url = "catalogo";

            var result = Barrel.Current.Get<List<Catalogo>>(key: url);
            var catalogo = (Catalogo)obj;
            var productoBorrado = result.Where(x => x.Name == catalogo.Name).FirstOrDefault();
            result.Remove(productoBorrado);
            DisplayAlert("Eliminar", $"{productoBorrado.Name} eliminado satisfactoriamente", "ok");
            Barrel.Current.Add(key: url, data: result, expireIn: TimeSpan.FromDays(200));
            CargarData();
            CargarTotal();
           



        }


        public void CargarData()
        {
            var url = "catalogo";
            if (!Barrel.Current.IsExpired(key: url))
            {
                var result = Barrel.Current.Get<List<Catalogo>>(key: url);

                var addData = new List<Catalogo>();
                foreach (var item in result)
                {
                    addData.Add(item);
                }
                Barrel.Current.Add(key: url, data: addData, expireIn: TimeSpan.FromDays(200));
                catalogo = new ObservableCollection<Catalogo>(addData);

                collecTest.ItemsSource = catalogo;
            }
        }

            private void CargarTotal()
            {
                var url = "catalogo";
                var result = Barrel.Current.Get<List<Catalogo>>(key: url);

            if (result == null)
            {
                return;
            }
                foreach (var item in result)
                {
                TxtTotal.Text = "";
                PriceCalculator += item.Price;

               
                }
                TxtTotal.Text = PriceCalculator.ToString();
                 PriceCalculator = 0;
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            catalogo = new ObservableCollection<Catalogo>();

            collecTest.ItemsSource = catalogo;
            DisplayAlert("Pedido enviado correctamente", "Tiempo Maximo de espera 15 Minutos","ok");
                // mensaje de pedido enviado...
        }
    }
    }
