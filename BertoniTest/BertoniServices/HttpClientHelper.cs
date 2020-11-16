using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BertoniServices
{
    public class HttpClientHelper
    {
        private string securityServer { get; set; } = "https://jsonplaceholder.typicode.com/";

        public async Task<string> GetUnAuthorized(string requestString)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");


                var response = client.GetAsync(securityServer + requestString).Result;
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
