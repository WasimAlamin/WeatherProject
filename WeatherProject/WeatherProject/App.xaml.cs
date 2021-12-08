using System;
using WeatherProject.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
         
            MainPage = new MainPage();
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
