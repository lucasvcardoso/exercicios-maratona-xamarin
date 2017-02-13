using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace DemoRelativeLayout
{
    [Activity(Label = "DemoRelativeLayout", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
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

