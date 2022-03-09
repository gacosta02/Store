
using GalloStore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GalloStore.ViewModels
{

      public  class CatalogoViewModel
    {
        public ObservableCollection<Catalogo> catalogos { get; set; }
        public CatalogoViewModel()
        {
            catalogos = new ObservableCollection<Catalogo>
            {
                new Catalogo {  Picture = "Aceite.png" , Name ="Aceite", Price ="123"  },
                new Catalogo {  Picture = "Agua.png", Name ="Aceite", Price ="123"   },
                new Catalogo {  Picture = "Ayuda.png", Name ="Aceite", Price ="123"  },
                new Catalogo {  Picture = "Casa.png", Name ="Aceite", Price ="123"      }
            };
        }
    }
}
