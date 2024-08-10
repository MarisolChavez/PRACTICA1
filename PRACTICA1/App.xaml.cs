using PRACTICA1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PRACTICA1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Home());
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
