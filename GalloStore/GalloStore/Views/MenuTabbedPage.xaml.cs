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
    public partial class MenuTabbedPage : TabbedPage
    {
        public MenuTabbedPage()
        {
            InitializeComponent();
        }



        protected override void OnAppearing()
        {
            base.OnAppearing();
            bool haskey = Preferences.ContainsKey("admin");
            if (haskey)
            {
                BuzonVoz.IsEnabled = false;
                BuzonVoz.IsVisible = false;
            }
        }
    }
}