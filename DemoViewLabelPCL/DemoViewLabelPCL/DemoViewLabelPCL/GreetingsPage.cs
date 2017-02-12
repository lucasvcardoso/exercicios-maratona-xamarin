using System;
using Xamarin.Forms;

namespace DemoViewLabelPCL
{
    public class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {

            var MyLabel = new Label();
            MyLabel.Text = "Greetings, Xamarin.Forms!";
            /*O método genérico estático Device.OnPlatform<T> leva 3 argumentos de tipo T, o primeiro
            para iOS, o segundo para Android e o terceiro para plataformas Windows. Temos que fazer isso porque
            senão o iOS coloca o texto em cima da barra de status. Burro.
            Padding = Device.OnPlatform<Thickness>(
                new Thickness(0, 20, 0, 0),
                new Thickness(0),
                new Thickness(0, 20, 0, 0)
                );*/
            /*O mesmo resultado pode ser obtido da seguinte forma:
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);*/
            /*Ou desta forma:
            Device.OnPlatform(iOS: () =>
                Padding = new Thickness(0, 20, 0, 0)
            );*/
            this.Content = MyLabel;
            /*Definindo estas propriedades, centralizamos o label. Para todas as plataformas.
            MyLabel.HorizontalOptions = LayoutOptions.Center;
            MyLabel.VerticalOptions = LayoutOptions.Center;*/
            /*Desta forma centralizamos o TEXTO e não o LABEL:*/
            MyLabel.HorizontalTextAlignment = TextAlignment.Center;
            MyLabel.VerticalTextAlignment = TextAlignment.Center;
        }
    }
}
