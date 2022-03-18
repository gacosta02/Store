using GalloStore.Models;
using MonkeyCache.FileStore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace GalloStore.ViewModels
{
     public class CarritoViewModel
    {
        Command _EliminarCommand;

        public Command EliminarCommand => _EliminarCommand ??
            (_EliminarCommand = new Command(EliminarSync));

        public ObservableCollection<Catalogo> catalogo { get; set; }

        public CarritoViewModel()
        {
            Barrel.ApplicationId = "store";
            // CargarData();
        }


        private void EliminarSync(object obj)
        {

            var url = "catalogo";

            var result = Barrel.Current.Get<List<Catalogo>>(key: url);
            var catalogo = (Catalogo)obj;
            var productoBorrado = result.Where(x => x.Name == catalogo.Name).FirstOrDefault();
            result.Remove(productoBorrado);


            Barrel.Current.Add(key: url, data: result, expireIn: TimeSpan.FromDays(200));
            



        }

        //public void CargarData()
        //{
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
        //        catalogo = new ObservableCollection<Catalogo>(addData);
                

        //    }
             

        //    }
    

    }
}
