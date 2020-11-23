using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DemoNetConf.CV;
using DemoNetConf.Droid.Renders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryCustom), typeof(EntryCustomRender))]
namespace DemoNetConf.Droid.Renders
{
    public class EntryCustomRender : EntryRenderer
    {
        public EntryCustomRender(Context context) : base(context)
        {
            AutoPackage = false;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                var propiedades = Element as EntryCustom;
                Control.SetPadding(0, 0, 0, 0);
                Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
                Control.SetTextColor(propiedades.TextColor.ToAndroid());
                Control.SetHintTextColor(propiedades.PlaceholderColor.ToAndroid());
            }
        }
    }
}