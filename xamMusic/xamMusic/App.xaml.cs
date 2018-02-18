using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using xamMusic.Models;

namespace xamMusic
{
	public partial class App : Application
	{
        public static Action<string> PostSuccessFacebookAction { get; set; }
        public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage (new LoginPage());
          /**  App.PostSuccessFacebookAction = async token =>
            {
                //you can use this token to authenticate to the server here
                //call your FacebookLoginService.LoginToServer(token)
                //I'll just navigate to a screen that displays the token:
                await  NavigationPage.PushAsync(new DiplayTokenPage(token));

            };*/
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
