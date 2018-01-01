using System;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Threading.Tasks;
namespace xamMusic.DreamFactoryAPI
{
    public class DreamFactoryAPI: ContentPage
    {
        private readonly string API_BASE_PATH= "http://52.90.138.148/api/v2/padoi";
        public Music_promoterApi apiInstance;
        /**
         * Set up api connection with base path and auth headers
         * */
        public DreamFactoryAPI()
        {
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
                Console.WriteLine("ERRRRR: " + e.StackTrace + "\nERRRR: " + e.Message);
                 DisplayAlert("ERRR", "ERR REsponse: \n" + e.Message,"ok");
            }
            return null;
        }
    }
}
