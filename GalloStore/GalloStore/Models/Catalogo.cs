using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GalloStore.Models
{
    public class Catalogo : INotifyPropertyChanged
    {
        public string Picture { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

