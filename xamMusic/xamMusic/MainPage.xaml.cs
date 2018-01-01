using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;
using Facebook;
namespace xamMusic
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
           /* Padding = Device.OnPlatform(
                iOS: new Thickness(0, 20, 0, 0),
                Android: new Thickness(10,20,0,0),
                WinPhone: new Thickness(30,20,0,0)
            );
            */
		}
       public void Login(object sender, EventArgs ea)
        {
            DreamFactoryAPI.DreamFactoryAPI api = new DreamFactoryAPI.DreamFactoryAPI();
            if (sender == this.loginBtnAuth)
            {
                this.label.Text = "Button pressed Auth!";
                MySqlDbs db =  api.ApiCallTestTableAuthAsync();
                if (db == null)
                {
                    
                    DisplayAlert("Response: ", "Error network connection...", "OK");
                }
                else
                {
                    List<MySqlDb> myList = db.Resource;
                    var res = string.Join(",", myList.Select(x => x.ToString()).ToArray());
                    DisplayAlert("Response: ", "Join ex:\n" + res, "OK");
                }
            }
            else
            {
                this.label.Text = "FB Button pressed!";
                
            }
        }
    }
}
