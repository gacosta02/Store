
using GalloStore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GalloStore.ViewModels
{

      public  class CatalogoViewModel
      {
        public ObservableCollection<Catalogo> catalogo { get; set; }
        public CatalogoViewModel()
        {
            catalogo = new ObservableCollection<Catalogo>
            {
                new Catalogo {  Picture = "Aceite.png" , Name ="Aceite Crisol", Price = 20  },
                new Catalogo {  Picture = "Agua.png", Name ="Agua", Price = 25  },
                new Catalogo {  Picture = "Leche.png", Name ="Leche", Price = 70  },
                new Catalogo {  Picture = "Evaporada.png", Name ="Leche Evaporada", Price = 75 },
                new Catalogo {  Picture = "Cafe.png", Name ="Cafe Santo Domingo", Price = 25 },
                new Catalogo {  Picture = "Mazorca.png", Name ="Harina Mazorca", Price = 15 },
                new Catalogo {  Picture = "Sopa.png", Name ="Sopa China", Price = 25 },
                new Catalogo {  Picture = "Sopita.png", Name ="Caldo de Gallina", Price = 7 },
                new Catalogo {  Picture = "Huevo.png", Name ="Huevo", Price = 8 },
                new Catalogo {  Picture = "Fosforo.png", Name ="Fosforo", Price = 5 },
                new Catalogo {  Picture = "Pasta.png", Name ="Espagueti", Price = 35 },
                new Catalogo {  Picture = "Platano.png", Name ="Platano", Price = 25 },
            };

            
        }



       }
}
