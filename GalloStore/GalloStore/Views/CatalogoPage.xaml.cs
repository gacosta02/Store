using GalloStore.ViewModels;
using System;
using System.Collections.Generic;
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
        public CatalogoPage()
        {
            InitializeComponent();
            this.BindingContext = new CatalogoViewModel();
        }
    }
}