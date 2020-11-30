using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace horoskopp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new hor();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
