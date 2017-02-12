using System;

using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarinFormsShared
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
#if __IOS__
                            Text = "Welcome to iOS Xamarin Forms!"
#endif
#if __ANDROID__
                            Text = "Welcome to Android Xamarin Forms!"
#endif
#if WINDOWS_UWP
                            Text = "Welcome to Windows Desktop/Mobile UWP Xamarin Forms"
#endif
#if WINDOWS_APP
                            Text = "Welcome to Windows 8 Xamarin Forms"
#endif
#if WINDOWS_PHONE_APP
                            Text = "Welcome to Windows Phone 8 Xamarin Forms"
#endif
                        }
                    }
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
