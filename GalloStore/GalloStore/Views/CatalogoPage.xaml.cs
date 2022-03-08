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
            private void TapMenos_Tapped(object sender, EventArgs e)
            {
                int cantidad = Convert.ToInt32(lblCantidad);
                if (cantidad > 1)
                {

                    cantidad -= 1;
                    lblCantidad.Text = cantidad.ToString();
                }

            }

            private void TapMas_Tapped(object sender, EventArgs e)
            {
                int cantidad = Convert.ToInt32(lblCantidad.Text);
                cantidad += 1;
                lblCantidad.Text = cantidad.ToString();
            }

        

        
    }
}