using Store.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Store.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuzonPage : ContentPage
    {
        public BuzonPage()
        {
            InitializeComponent();
            this.BindingContext = new BuzonViewModel();

        }
    }
}