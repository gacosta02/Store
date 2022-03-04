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
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();
            this.BindingContext = new RegistroViewModel();

            string dc = NombreUsuario.Text;
            string mc = Contraseña_Registro.Text;
            string ab = Direccion.Text;
            string cd = Celular.Text;

           String lm = "Admin";
           String Rm = "123";
           String Dm = "Calle r2 no28";
           String Rn = "8295940077";

            Registrar.Clicked += (sender, e) =>
            {
                

                if (NombreUsuario.Text ==lm || Contraseña_Registro.Text == Rm || Direccion.Text ==Dm || Celular.Text ==Rn )
                {
                    _ = DisplayAlert("Advertencia", "Usuario Registrado", "OK");
                    Navigation.PushAsync(new LoginPage());
                    NombreUsuario.Text = "";
                    Contraseña_Registro.Text = "";
                    Direccion.Text = "";
                    Celular.Text = "";
                }

                else if (String.IsNullOrEmpty(dc) | String.IsNullOrEmpty(mc) | String.IsNullOrEmpty(ab) | String.IsNullOrEmpty(cd))
                {
                    _ = DisplayAlert("Advertencia", "Campo Vacio", "OK");
                }
                
                
               
                

            };
        }
    }
}