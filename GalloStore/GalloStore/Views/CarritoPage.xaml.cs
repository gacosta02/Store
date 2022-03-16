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
        public ObservableCollection<Catalogo> catalogo { get; set; }
        public CarritoPage()
        {
            InitializeComponent();
            this.BindingContext = new CarritoViewModel();
            Barrel.ApplicationId = "store";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = new CarritoViewModel();
            //CargarData();
        }

        //private void CargarData()
       // {
        //    var url = "catalogo";
        //    if (!Barrel.Current.IsExpired(key: url))
        //    {
        //        var result = Barrel.Current.Get<List<Catalogo>>(key: url);

        //        var addData = new List<Catalogo>();
        //        foreach (var item in result)
        //        {
        //            addData.Add(item);
        //        }
              



        //        Barrel.Current.Add(key: url, data: addData, expireIn: TimeSpan.FromDays(200));

        //        foreach (var item in addData)
        //        {
        //            catalogo = new ObservableCollection<Catalogo> {
        //        new Catalogo {
        //            Price = item.Price, Name = item.Name, Picture = item.Picture
        //        } };

               
        //        }
               


        //    }
        //}
    }
}