using System;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Auth;
using System.Diagnostics;

namespace xamMusic.DreamFactoryAPI
{
    public class DreamFactoryAPI: ContentPage
    {
        private readonly string API_BASE_PATH= "http://52.90.138.148/api/v2";
        public Music_promoterApi apiInstance;

        public static string APP_ID = "270685116790734";

        public enum SERVICE {PADOI, FACEBOOK_LOGIN};
        public enum CONSTANTS { public_profile, user_friends,email };
        /**
* Set up api connection with base path to Selected SERVICE and auth headers
* Need dream factory api key" X-DreamFactory-API-Key "  and "user-secret-api-key" api key. 
* */
        public DreamFactoryAPI(SERVICE service)
        {
            API_BASE_PATH += "/" + service.ToString().ToLower();
            apiInstance = new Music_promoterApi(API_BASE_PATH);
            apiInstance.Configuration.ApiKey["X-DreamFactory-API-Key"] = "e90ba5d8e6d773ecd6f189a819c9ed310151a0ccaf494ebb1b2bfc2ad62f58fe";
            apiInstance.Configuration.ApiKey["user-secret-api-key"] = "2hDanqbde9LroE689VJXw6zJeDW9JipAGD5SZv8H926NY8w0AY69v6q4VCC6";
        }
        /**
         * 
         * 
         * */
        public DreamFactoryAPI()
        {
            API_BASE_PATH += "/" + SERVICE.PADOI.ToString().ToLower();
            apiInstance = new Music_promoterApi(API_BASE_PATH);
            apiInstance.Configuration.ApiKey["X-DreamFactory-API-Key"] = "e90ba5d8e6d773ecd6f189a819c9ed310151a0ccaf494ebb1b2bfc2ad62f58fe";
            apiInstance.Configuration.ApiKey["user-secret-api-key"] = "2hDanqbde9LroE689VJXw6zJeDW9JipAGD5SZv8H926NY8w0AY69v6q4VCC6";
        }


        public MySqlDbs ApiCallTestTableAuthAsync()
        {
            List<string> fields = new List<string>();
            List<int?> id = new List<int?>();
             
            
            try
            {
               MySqlDbs result =  apiInstance.GetMusicPromoterResources();

                return JsonConvert.DeserializeObject<MySqlDbs>(result.ToJson());
            }
            catch (Exception e)
            {
                Debug.WriteLine("ERRRRR: " + e.StackTrace + "\nERRRR: " + e.Message);
                 DisplayAlert("ERRR", "ERR REsponse: \n" + e.Message,"ok");
            }
            return null;
        }
        public string FBServiceRequestString()
        {
            return "https://www.facebook.com/v2.11/dialog/oauth?client_id="+APP_ID+"&display=popup&response_type=token&redirect_uri=https://www.facebook.com/connect/login_success.html";
        }
        /**
         * Attempt to use Xamarin OAuth for FB api access.
         * */
        public void OAuth()
        {
            try
            {
                string FB_REDIRCT_URL = "https://www.facebook.com/connect/login_success.html#access_token";
                string FB_AUTH_URL = "https://www.facebook.com/v2.12/dialog/oauth?client_id=" + APP_ID + "&redirect_uri=" + FB_REDIRCT_URL + "&state={" + "{st=state123abc,ds=123456789" + "}";
                string FB_ACCESS_TOKEN_URL = "https://www.facebook.com/connect/login_success.html#access_token";
                var authenticator = new OAuth2Authenticator(
                                                     APP_ID,
                                                     null,
                                                     CONSTANTS.public_profile + "," + CONSTANTS.email + "," + CONSTANTS.user_friends,
                                                     new Uri(FB_AUTH_URL),
                                                     new Uri(FB_REDIRCT_URL),
                                                     new Uri(FB_ACCESS_TOKEN_URL),
                                                     null,
                                                     true);
                /*GET https://graph.facebook.com/v2.12/oauth/access_token?
                client_id={app-id}
                &redirect_uri={redirect-uri}
                &client_secret={app-secret}
                &code={code-parameter}
                */
                authenticator.Completed += OnAuthCompleted;
                var presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
                presenter.Login(authenticator);
            }
            catch(Exception e)
            {
                Debug.WriteLine("Error.....: " + e.Message);
            }
        }

        private void OnAuthCompleted(object sender, AuthenticatorCompletedEventArgs e)
        {
            Debug.WriteLine("ON COMPLETE!!!::: "+e.ToString());
        }
    }
}