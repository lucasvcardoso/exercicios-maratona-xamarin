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

namespace DemoPortable.Droid.Implementations
{
    class Printer : IPrinter
    {
        public void ShowMessage()
        {
            Console.WriteLine("Hello from Xamarin");
            Console.WriteLine(Android.OS.Build.VERSION.Sdk);             
        }
    }
}