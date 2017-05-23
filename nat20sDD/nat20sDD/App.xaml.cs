using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace nat20sDD
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new nat20sDD.MainPage();
            SetMainPage();
		}

        public static void SetMainPage()
        {
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new nat20sDD.MainPage())
                    {
                        Title = "Home",
                        Icon = Device.OnPlatform<string>("tab_feed.png",null,null)
                    },
                     new NavigationPage(new nat20sDD.AboutPage())
                    {
                        Title = "About",
                        Icon = Device.OnPlatform<string>("tab_about.png",null,null)
                    },
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
