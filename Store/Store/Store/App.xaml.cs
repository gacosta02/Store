using Store.Services;
using Store.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Store
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            // MainPage = new AppShell();
            MainPage = new RegistroPage();
           // MainPage = new LoginPage();
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
