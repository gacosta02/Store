using GalloStore.Models;
using GalloStore.ViewModels;
using MonkeyCache.FileStore;
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
            Barrel.ApplicationId = "store";
            Acceder.Clicked += (sender, e) =>
            {

                string User = Usuario.Text;
                string Password = Contraseña.Text;

                var url = "Registro";
                var result = Barrel.Current.Get<List<Registro>>(key: url);

                  
                //Navigation.PushAsync(new MenuUserTabbedPage());
               
                if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Password))
                {
                    _ = DisplayAlert("Advertencia", "Campo Vacio", "OK");
                    return;
                }

                if (User == "admin" && Password == "admin")
                {
                    App.Current.MainPage = new MenuTabbedPage();
                    return;
                }

                if (result == null)
                {
                    _ = DisplayAlert("Advertencia", "Usuario no registrado, Favor registrarse", "OK");
                    App.Current.MainPage = new BienvenidaPage();
                    return;
                }
                
                foreach (var item in result)
                {
                    if (User == item.NombreUsuario && Password == item.Contrasena)
                    {
                        App.Current.MainPage = new MenuUserTabbedPage();
                        return;
                    }
                  
                }

              
                    _ = DisplayAlert("Advertencia", "Usuario o Contraseña incorrecta", "OK");
                //}
                //else if (lm ==  && dm == pwd.Item1)
                //{
                //    Navigation.PushAsync(new MenuTabbedPage());
                //    Usuario.Text = "";
                //    Contraseña.Text = "";
                //    Preferences.Set("admin", id);

                //}
                //    else if (lm == user.Item2 && dm == pwd.Item2)
                //{
                //    Navigation.PushAsync(new MenuTabbedPage());
                //    Usuario.Text = "";
                //    Contraseña.Text = "";
                //}
                //else
                //{
                //    _ = DisplayAlert("Advertencia", "Usuario o Contraseña incorrecta", "OK");
                //}








            };
        }

        
    }
}