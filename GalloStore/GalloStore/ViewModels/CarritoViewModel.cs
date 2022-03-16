using GalloStore.Models;
using MonkeyCache.FileStore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GalloStore.ViewModels
{
     public class CarritoViewModel
    {
        public ObservableCollection<Catalogo> catalogo { get; set; }

        public CarritoViewModel()
        {
            Barrel.ApplicationId = "store";
             CargarData();
        }


        private void CargarData()
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

                foreach (var item in addData)
                {
                    catalogo = new ObservableCollection<Catalogo> {
                new Catalogo {
                    Price = item.Price, Name = item.Name, Picture = item.Picture
                } };


                }

                

            }
        }

    }
}
