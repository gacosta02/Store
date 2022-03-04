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
    public partial class SoportePage : ContentPage
    {
        public SoportePage()
        {
            InitializeComponent();
            this.BindingContext = new SoporteViewModel();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           //await Email.ComposeAsync(EntryAsunto.Text, " ", EntryEMail.Text);

            string id = EntryAsunto.Text;

            if (string.IsNullOrEmpty(id))
            {
                _ = DisplayAlert("Advertencia", "El campo Asunto esta vacio", "OK");
            }
            else
            {
                
                await Email.ComposeAsync(EntryAsunto.Text, " ", EntryEMail.Text);
                EntryAsunto.Text = "";

            }
        }

        
    }
}

//var mensaje = new EmailMessage(EntryAsunto.Text, "", EntryEMail.Text);
//mensaje.BodyFormat = EmailBodyFormat.PlainText;
//await Email.ComposeAsync(mensaje);