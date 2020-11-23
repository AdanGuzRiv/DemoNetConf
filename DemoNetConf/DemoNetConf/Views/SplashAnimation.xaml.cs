using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoNetConf.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashAnimation : ContentPage
    {
        public SplashAnimation()
        {
            InitializeComponent();          
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await splashImage.ScaleTo(1, 700, Easing.Linear);
            await splashImage.ScaleTo(1.2, 700, Easing.Linear);
            await splashImage.RotateTo(5, 700, Easing.SinIn);
            await etiquetaSplash.FadeTo(1, 1200, Easing.SpringIn);
            await etiquetaSplash.ScaleTo(1, 500, Easing.CubicInOut);
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}