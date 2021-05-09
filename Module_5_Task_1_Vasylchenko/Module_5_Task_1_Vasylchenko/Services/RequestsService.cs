using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Module_5_Task_1_Vasylchenko.Models;
using Newtonsoft.Json;

namespace Module_5_Task_1_Vasylchenko.Services
{
    public class RequestsService
    {
        public async Task<T> SendAsync<T>(HttpStatusCode httpStatusCode, HttpMethod httpMethod, string link, object obj = null)
        {
            using (var httpClient = new HttpClient())
            {
                var httpContent = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
                var httpMessage = new HttpRequestMessage();

                httpMessage.Content = httpContent;
                httpMessage.RequestUri = new Uri(@link);
                httpMessage.Method = httpMethod;

                var result = await httpClient.SendAsync(httpMessage);
                Console.WriteLine(result.StatusCode);
                if (result.StatusCode == httpStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var respose = JsonConvert.DeserializeObject<T>(content);
                    Console.WriteLine(respose);
                    return respose;
                }

                return default(T);
            }
        }
    }
}
