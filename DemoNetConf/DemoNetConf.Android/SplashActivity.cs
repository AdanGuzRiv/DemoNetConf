using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoNetConf.Droid
{
    [Activity(Label = "Net Conferencia", Theme = "@style/StyleSplashFull", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistableBundle)
        {
            base.OnCreate(savedInstanceState, persistableBundle);
            // Create your application here
        }
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(new Intent(this, typeof(MainActivity)));
        }
    }
}