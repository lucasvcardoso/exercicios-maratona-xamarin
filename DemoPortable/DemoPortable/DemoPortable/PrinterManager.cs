using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPortable
{
    public class PrinterManager
    {
        public IPrinter Printer { get; set; }
        public PrinterManager(IPrinter printer)
        {
            this.Printer = printer;
        }
        public void ShowMessage()
        {
            Printer.ShowMessage();
        }
    }
}
