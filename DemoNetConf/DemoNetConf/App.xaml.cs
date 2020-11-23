using DemoNetConf.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoNetConf
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SplashAnimation();
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
