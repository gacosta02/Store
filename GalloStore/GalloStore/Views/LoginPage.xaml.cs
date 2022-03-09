using GalloStore.ViewModels;
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
                var user =  ("admin"," rachely");
                var pwd = ("1234", "1234");
                
                string lm = Usuario.Text;
                string dm = Contraseña.Text;
      
                if (lm == user.Item1 && dm == pwd.Item1 )
                {
                    Navigation.PushAsync(new MenuTabbedPage());
                    Usuario.Text = "";
                    Contraseña.Text = "";
                    Preferences.Set("Admin", id);
                }
                if (lm == user.Item2 && dm == pwd.Item2)
                {
                    Navigation.PushAsync(new MenuTabbedPage());
                    Usuario.Text = "";
                    Contraseña.Text = "";
                }
                //else if (string.IsNullOrEmpty(lm) || string.IsNullOrEmpty(dm))
                //{
                //    _ = DisplayAlert("Advertencia", "Campo Vacio", "OK");


                //}
                //else
                //{
                //    _ = DisplayAlert("Advertencia", "Usuario o Contraseña incorrecta", "OK");
                //}




            };
        }

        
    }
}