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
    public partial class LoginPage : ContentPage
    {
        

        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();

            Acceder.Clicked += (sender, e) =>
            {

                //Navigation.PushAsync(new MenuTabbedPage());

                String id = "Admin";
                String mc = "123";

                string lm = Usuario.Text;
                string dm = Contraseña.Text;

                if (Usuario.Text == id || Contraseña.Text == mc)
                {
                    Navigation.PushAsync(new MenuTabbedPage());
                    Usuario.Text = "";
                    Contraseña.Text = "";
                }
                else if (string.IsNullOrEmpty(lm) || string.IsNullOrEmpty(dm))
                {
                    _ = DisplayAlert("Error", "El campo Asunto esta vacio", "OK");


                }
                else
                {
                    _ = DisplayAlert("Error", "Usuario o Contraseña incorrecta", "OK");
                }

               
            

            };
        }

        
    }
}