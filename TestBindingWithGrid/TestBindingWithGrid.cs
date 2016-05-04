using System;

using Xamarin.Forms;

namespace TestBindingWithGrid
{
	public class App : Application
	{

		public static Globali Glob = new Globali();
		public App ()
		{
	
			MainPage = new MyPage ();
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

