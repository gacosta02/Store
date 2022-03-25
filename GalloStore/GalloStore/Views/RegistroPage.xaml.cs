using GalloStore.Models;
using GalloStore.ViewModels;
using MonkeyCache.FileStore;
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

        Command _RegistroCommand;

        public Command RegistroCommand => _RegistroCommand ??
            (_RegistroCommand = new Command(RegistroSync));

        public string nombreUsuario { get; set; } 
        public string direccion { get; set; } 
        public string celular { get; set; }
        public string contrasena { get; set; }
        public RegistroPage()
        {
            InitializeComponent();
            Barrel.ApplicationId = "store";
            this.BindingContext = new RegistroViewModel();




            Registrar.Clicked += (sender, e) =>
            {


                 if (String.IsNullOrEmpty(nombreUsuario) | String.IsNullOrEmpty(contrasena) | String.IsNullOrEmpty(celular) | String.IsNullOrEmpty(direccion))
                {
                    _ = DisplayAlert("Advertencia", "Campo Vacio", "OK");
                }

                 else if (NombreUsuario.Text == nombreUsuario|| Contraseña_Registro.Text == contrasena || Direccion.Text == direccion || Celular.Text == celular )
                {
                    _ = DisplayAlert("Advertencia", "Usuario Registrado", "OK");
                   // Navigation.PushAsync(new LoginPage());
                    App.Current.MainPage = new LoginPage();
                    NombreUsuario.Text = "";
                    Contraseña_Registro.Text = "";
                    Direccion.Text = "";
                    Celular.Text = "";
                }
                //else if (String.IsNullOrEmpty(nombreUsuario) | String.IsNullOrEmpty(contrasena) | String.IsNullOrEmpty(celular) | String.IsNullOrEmpty(direccion))
                //{
                //    _ = DisplayAlert("Advertencia", "Campo Vacio", "OK");
                //}
                
                
               
                

            };
        }



        private void RegistroSync(object obj)
        {
            GetData();
            var url = "Registro";
            var registro = new List<Registro>()
            {
               new Registro { 
                NombreUsuario = nombreUsuario,
                Celular = celular,
                Direccion = direccion,
                Contrasena = contrasena }
            };
            //registro.Add(new Registro());

            var result = Barrel.Current.Get<List<Registro>>(key: url);
            if (result == null)
            {
                Barrel.Current.Add(key: url, data: registro, expireIn: TimeSpan.FromDays(200));
                return;
            }
              result.Add( new Registro());
            foreach (var item in registro)
            {
                result.Add(item);
            }
          //  result.Add(new Registro());
          //  DisplayAlert("Agregar", "Producto Agregado satisfactoriamente", "ok");
            Barrel.Current.Add(key: url, data: result, expireIn: TimeSpan.FromDays(200));
        }

        private void GetData()
        {

            nombreUsuario = NombreUsuario.Text;
            direccion = Direccion.Text;
            celular = Celular.Text;
            contrasena = Contraseña_Registro.Text;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var afda = nombreUsuario;
        }
    }
}