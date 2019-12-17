using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Support.Helper
{
   public class WebApiHelper
    {
        public async static Task<T> Get<T>(string url, Dictionary<string, string> headers)
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetStringAsync(new Uri(url));
                return JsonConvert.DeserializeObject<T>(result);
            }
        }
    }
}
