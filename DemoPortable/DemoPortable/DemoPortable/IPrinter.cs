using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPortable
{
    public interface IPrinter
    {
        //Em projetos do tipo Portable Class Library, temos que utilizar o conceito de interfaces
        //para mudar a arquitetura de modo a conseguir o mesmo comportamento.
        //A classe Console, por exemplo, não está disponível
        void ShowMessage();
    }
}
