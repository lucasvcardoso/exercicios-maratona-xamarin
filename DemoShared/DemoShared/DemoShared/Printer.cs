using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importamos este namespace para poder usar o método Debug.WriteLine() no WP8
using System.Diagnostics;

namespace DemoShared
{
    public class Printer
    {
        public void ShowMessage()
        {
            /*Utilizamos estas diretivas de compilação para utilizar o código contido dentro dos IFs somente nas plataformas indicadas
             na diretiva.*/
#if __MOBILE__
            /*Esta diretiva é utilizada para compilar códigos tanto para Android quanto iOS.
            Precisamos utilizá-la porque no Windows Phone não é possível utilizar a classe Console para chamar
            o método WriteLine, deve-se chamar o namespace System.Diagnostics, e utilizar a classe
            Debug, com o método WriteLine()*/
            Console.WriteLine("Hello from Xamarin");
#endif
#if __ANDROID__
             /*Esta diretiva é utilizada para compilar somente para Android.
             Aqui utilizamos uma API nativa do Android para obter a versão do sistema*/
             Console.WriteLine(Android.OS.Build.VERSION.Sdk);
#else
#if WINDOWS_PHONE_APP
            /*Esta diretiva é utilizada para compilar somente para Windows Phone 8/8.1.
             Neste caso, o Windows Phone 8 não disponibiliza uma forma de obter a versão do sistema em um 
             app rodando diretamente no runtime. Isso só é possível em apps Silverlight.*/
            // Windows Phone 8
            Debug.WriteLine("Hello from Xamarin, Windows Phone 8 bundão");
            
#endif
#endif

        }
    }
}
