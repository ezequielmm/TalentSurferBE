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
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, url);
            foreach (var header in headers ?? new Dictionary<string, string>())
            {
                httpRequest.Headers.Add(header.Key, header.Value);
            }
            string responseString = null;
            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.SendAsync(httpRequest);
                responseString = await httpResponse.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseString);
            }
        }
    }
}
