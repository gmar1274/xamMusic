
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamMusic.Models;

namespace xamMusic.ContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FBContentPage : ContentPage
	{
        private WebView webView;
        public FBContentPage()
        {
            InitializeComponent();
            var api = new DreamFactoryAPI.DreamFactoryAPI(DreamFactoryAPI.DreamFactoryAPI.SERVICE.FACEBOOK_LOGIN);
            var apiRequest = api.FBServiceRequestString();
             webView = new WebView
            {
                Source = apiRequest,
                HeightRequest = 1
            };
            webView.Navigated += WebViewOnNavigated;
            Content = webView;
         }
        private async void WebViewOnNavigated(object sender, WebNavigatedEventArgs e)
        {
           // Debug.WriteLine("ONNavigate::::::: " + e.Url);
            var accessToken = ExtractAccessTokenFromURL(e.Url);
            if(accessToken != String.Empty )
            {
              webView.IsVisible = false;
              var user = await GetFacebookProfileAsync(accessToken);
              await LoginSuccessAsync(user);
            }
        }

        private async Task LoginSuccessAsync(FacebookProfile user)
        {

            Navigation.RemovePage(this);
            await Navigation.PushAsync(new MainPage(user));
        }

        private string ExtractAccessTokenFromURL(string url)
        {
            if (url.Contains("access_token") && url.Contains("&expires_in="))
            {
                var at = url.Replace("https://www.facebook.com/connect/login_success.html#access_token=", "");
                var accessToken = at.Remove(at.IndexOf("&expires_in="));
               
                return accessToken;
            }
            return string.Empty;
        }
        public async Task<FacebookProfile> GetFacebookProfileAsync(string accessToken)
        {
            try
            {
                
                var requestUrl = "https://graph.facebook.com/v2.7/me/" + "?fields=name,picture,cover,email,is_verified,gender" + "&access_token=" + accessToken;
                var httpClient = new HttpClient();
                var userJson = await httpClient.GetStringAsync(requestUrl);
                var fb = JsonConvert.DeserializeObject<FacebookProfile>(userJson);
                return fb;


            }
            catch(Exception e)
            {
                Debug.WriteLine("Exception: " + e.Message);  
            }
            return null;
           
        }

    }
}