using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DemoActivities
{
    [Activity(Label = "VistaCapital")]
    public class VistaCapital : Activity
    {
        double defaultValue;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.VistaCapital);
            EditText txtCapitalBrasil = FindViewById<EditText>(Resource.Id.txtCapitalBrasil);
            EditText txtCapitalColombia = FindViewById<EditText>(Resource.Id.txtCapitalColombia);
            ImageView imgBrasil = FindViewById<ImageView>(Resource.Id.imgBrasil);
            ImageView imgColombia = FindViewById<ImageView>(Resource.Id.imgColombia);
            Button btnSair = FindViewById<Button>(Resource.Id.btnSair);

            try
            {
                
                //Usa-se Intent.GetDoubleExtra() para buscar os valores enviados pela activity anterior
                txtCapitalBrasil.Text = Intent.GetDoubleExtra("capitalBrasil", defaultValue).ToString();
                txtCapitalColombia.Text = Intent.GetDoubleExtra("capitalColombia", defaultValue).ToString();
                imgBrasil.SetImageResource(Resource.Drawable.brasil);
                imgColombia.SetImageResource(Resource.Drawable.colombia);
            }
            catch (Exception ex)
            {
                Toast.MakeText
                        (this, ex.Message,
                        ToastLength.Short).Show();
            }

            btnSair.Click += delegate
            {
                //Utilizamos esta instrução para matar o processo da própria Activity da memória, e fechar o app
                Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
            };
        }
    }
}