using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Crashes;
namespace DemoRelativeLayout
{
    [Activity(Label = "DemoRelativeLayout", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            MobileCenter.Start("2052f06d-8d46-4c68-93f8-b27b23b40946",
                    typeof(Analytics), typeof(Crashes));
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            Button btnConverter = FindViewById<Button>(Resource.Id.btnConverter);
            EditText txtDolares = FindViewById<EditText>(Resource.Id.txtDolares);
            EditText txtReais = FindViewById<EditText>(Resource.Id.txtReais);
            double reais, dolares;
            btnConverter.Click += delegate
             {
                 try
                 {
                     Analytics.TrackEvent("Button clicked", new Dictionary<string, string> { { "Category", "Button Clicked" }, { "btnConverter", "Converter" } });
                     dolares = double.Parse(txtDolares.Text);
                     reais = dolares * 3.11;
                     txtReais.Text = reais.ToString();
                 }
                 catch(Exception ex)
                 {
                     Toast.MakeText
                         (this, ex.Message,
                         ToastLength.Short).Show();
                 }
             };

        }
    }
}

