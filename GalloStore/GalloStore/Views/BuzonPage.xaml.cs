using GalloStore.ViewModels;
using GalloStore.Views;
using System;
using System.Collections.Generic;
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
        
        

        public BuzonPage()
        {
            InitializeComponent();
            this.BindingContext = new BuzonViewModel();
        }








        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    bool hasKey = Preferences.ContainsKey("admin");
        //    if (hasKey)
        //    {
        //        BuzonVoz.IsEnabled = false;
        //        BuzonVoz.IsVisible = false;
        //    }
        //}
    }
}