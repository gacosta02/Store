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
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GalloStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuzonPage : ContentPage
    {


        public ObservableCollection<Catalogo> catalogo { get; set; }


        public int PriceCalculator { get; set; }
        public BuzonPage()
        {
            InitializeComponent();
            this.BindingContext = new BuzonViewModel();
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
                //  Barrel.Current.Add(key: url, data: addData, expireIn: TimeSpan.FromDays(200));
                catalogo = new ObservableCollection<Catalogo>(addData);

                collecTest.ItemsSource = catalogo;
            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CargarData();
            CargarTotal();
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
    }
}
