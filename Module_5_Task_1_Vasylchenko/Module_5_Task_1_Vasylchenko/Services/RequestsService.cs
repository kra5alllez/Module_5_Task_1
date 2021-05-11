using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Module_5_Task_1_Vasylchenko.Models;
using Module_5_Task_1_Vasylchenko.Services.InterfaceServisec;
using Newtonsoft.Json;

namespace Module_5_Task_1_Vasylchenko.Services
{
    public class RequestsService : IRequestsService
    {
        private readonly Config _config;
        private readonly IConfigService _configService;
        private readonly ILoggerService _loggerService;

        public RequestsService()
        {
            _configService = LocatorService.ConfigService;
            _loggerService = LocatorService.LoggerService;
            _config = _configService.ReturnConfig();
        }

        public async Task<T> SendAsync<T>(HttpMethod httpMethod, string linkTwo, object obj = null)
        {
            using (var httpClient = new HttpClient())
            {
                var httpMessage = new HttpRequestMessage();
                if (obj != null)
                {
                    httpMessage.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
                }

                httpMessage.RequestUri = new Uri(_config.Link + linkTwo);
                httpMessage.Method = httpMethod;

                var result = await httpClient.SendAsync(httpMessage);
                if (result.StatusCode == HttpStatusCode.BadRequest)
                {
                    try
                    {
                        return await ActAsync<T>(result);
                    }
                    catch
                    {
                        _loggerService.LogError(result.StatusCode);
                    }
                }
                else if (result.StatusCode == HttpStatusCode.OK || result.StatusCode == HttpStatusCode.Created)
                {
                    return await ActAsync<T>(result);
                }

                _loggerService.LogError(result.StatusCode);
                return default(T);
            }
        }

        private async Task<T> ActAsync<T>(HttpResponseMessage result)
        {
            var content = await result.Content.ReadAsStringAsync();
            var respose = JsonConvert.DeserializeObject<T>(content);
            _loggerService.LogSucces(result.StatusCode);
            return respose;
        }
    }
}
