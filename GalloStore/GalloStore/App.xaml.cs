using GalloStore.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GalloStore
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            // MainPage = new BienvenidaPage();
            // MainPage = new LoginPage();
            //MainPage = new RegistroPage();
            MainPage = new NavigationPage(new MenuTabbedPage());
            //MainPage = new HomePage();
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
