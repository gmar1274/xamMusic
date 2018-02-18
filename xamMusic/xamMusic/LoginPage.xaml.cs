using IO.Swagger.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Xamarin.Forms;
using xamMusic.ContentPages;
using xamMusic.Models;

namespace xamMusic
{
    public partial class LoginPage : ContentPage
	{
        
        public LoginPage()
		{
			InitializeComponent();
  
		}

        public void Login(object sender, EventArgs ea)
        {
            DreamFactoryAPI.DreamFactoryAPI api = new DreamFactoryAPI.DreamFactoryAPI();
            if (sender == this.loginBtnAuth)
            {
                this.label.Text = "Button pressed Auth!";
                MySqlDbs db = api.ApiCallTestTableAuthAsync();
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
                
                Navigation.PushAsync(new FBContentPage());
            }
        }
    }
}
