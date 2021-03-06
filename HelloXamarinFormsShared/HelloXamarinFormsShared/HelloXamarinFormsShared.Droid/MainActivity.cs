﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.Azure.Mobile;

namespace HelloXamarinFormsShared.Droid
{
	[Activity (Label = "HelloXamarinFormsShared", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
            MobileCenter.Configure("2052f06d-8d46-4c68-93f8-b27b23b40946");
            LoadApplication (new HelloXamarinFormsShared.App ());
		}
	}
}

