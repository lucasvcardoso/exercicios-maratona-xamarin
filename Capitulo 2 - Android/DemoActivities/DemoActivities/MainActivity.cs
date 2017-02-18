using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using System.IO;
using SQLite;

namespace DemoActivities
{
    [Activity(Label = "DemoActivities", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        /*Alterado o projeto original para incluir funcionalidade de SQLite*/
        protected override void OnCreate(Bundle savedInstanceState)
        {
            MobileCenter.Start("2052f06d-8d46-4c68-93f8-b27b23b40946", typeof(Analytics), typeof(Crashes));
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            //Getting from the System the path in which the database will be created
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            path = Path.Combine(path, "Base.db3");
            var conn = new SQLiteConnection(path);
            conn.CreateTable<Information>();
            //Variáveis para trabalhar com as views da GUI
            Button btnCalcular = FindViewById<Button>(Resource.Id.btnCalcular);
            EditText txtReceitasBrasil = FindViewById<EditText>(Resource.Id.txtReceitasBrasil);
            EditText txtDespesasBrasil = FindViewById<EditText>(Resource.Id.txtDespesasBrasil);
            EditText txtReceitasColombia = FindViewById<EditText>(Resource.Id.txtReceitasColombia);
            EditText txtDespesasColombia = FindViewById<EditText>(Resource.Id.txtDespesasColombia);
            double receitaBrasil, receitaColombia, despesaBrasil, despesaColombia, capitalBrasil, capitalColombia;
            btnCalcular.Click += delegate
            {
                try
                {
                    receitaBrasil = double.Parse(txtReceitasBrasil.Text);
                    receitaColombia = double.Parse(txtReceitasColombia.Text);
                    despesaBrasil = double.Parse(txtDespesasBrasil.Text);
                    despesaColombia = double.Parse(txtDespesasColombia.Text);
                    capitalBrasil = receitaBrasil - despesaBrasil;
                    capitalColombia = receitaColombia - despesaColombia;
                    var insert = new Information();
                    insert.ReceitasBrasil = receitaBrasil;
                    insert.DespesasBrasil = despesaBrasil;
                    insert.ReceitasColombia = receitaColombia;
                    insert.DespesasColombia = despesaColombia;
                    conn.Insert(insert);
                    Toast.MakeText(this, "Inserted in SQLite", ToastLength.Long).Show();
                    Load(capitalBrasil, capitalColombia);
                }
                catch (Exception ex)
                {
                    Toast.MakeText
                        (this, ex.Message,
                        ToastLength.Short).Show();
                }
            };

        }

        private void Load(double capitalBrasil, double capitalColombia)
        {
            //Objeto utilizado para criar uma nova instância da Activity a ser chamada
            Intent objIntent = new Intent(this, typeof(VistaCapital));
            //Método PutExtra() utilizado para passar um valor para a nova Activity
            objIntent.PutExtra("capitalBrasil", capitalBrasil);
            objIntent.PutExtra("capitalColombia", capitalColombia);
            //Método StartActivity() para iniciar a nova activity
            StartActivity(objIntent);
        }
    }
}


