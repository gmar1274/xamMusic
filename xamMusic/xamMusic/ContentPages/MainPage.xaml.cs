using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamMusic.Models;

namespace xamMusic.ContentPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        private string userJson;

        public MainPage(FacebookProfile prof)
        {
            InitializeComponent();
            this.profile_pic.Source = prof.Picture.Data.Url;


            this.label.Text = prof.Name + "\n" + prof.Id;
        }
        public MainPage ()
		{
			InitializeComponent ();
            
		}

        public MainPage(string userJson)
        {
           
            InitializeComponent();
            this.userJson = userJson;
            this.label.Text = this.userJson.ToString();
        }
    }
}