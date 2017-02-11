using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DemoPortable.WinPhone.Implementations
{
    class Printer : IPrinter
    {
        public void ShowMessage()
        {
            Debug.WriteLine("Hello from Xamarin, Windows Phone 8 bundão");
        }
    }
}
