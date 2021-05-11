using System.Net.Http;
using System.Threading.Tasks;
using Module_5_Task_1_Vasylchenko.Models.ModelsFour;
using Module_5_Task_1_Vasylchenko.Models.ModelsOne;
using Module_5_Task_1_Vasylchenko.Models.ModelsThree;
using Module_5_Task_1_Vasylchenko.Models.ModelsTwo;
using Module_5_Task_1_Vasylchenko.Services;
using Module_5_Task_1_Vasylchenko.Services.InterfaceServisec;

namespace Module_5_Task_1_Vasylchenko
{
    public class Starter
    {
        private readonly IRequestsService _requests;
        private readonly HttpMethod _httpMethodDelete = HttpMethod.Delete;
        private readonly HttpMethod _httpMethodGet = HttpMethod.Get;
        private readonly HttpMethod _httpMethodPost = HttpMethod.Post;
        private readonly HttpMethod _httpMethodPut = HttpMethod.Put;
        private readonly HttpMethod _httpMethodPatch = HttpMethod.Patch;
        public Starter()
        {
            _requests = LocatorService.RequestsService;
            _httpMethodDelete = HttpMethod.Delete;
            _httpMethodGet = HttpMethod.Get;
            _httpMethodPost = HttpMethod.Post;
            _httpMethodPut = HttpMethod.Put;
            _httpMethodPatch = HttpMethod.Patch;
        }

        public void Run()
        {
            Task.Run(async () => await _requests.SendAsync<ResponseOne>(_httpMethodGet, "/api/users?page=2"));

            Task.Run(async () => await _requests.SendAsync<ResponseTwo>(_httpMethodGet, "/api/users/2"));

            Task.Run(async () => await _requests.SendAsync<ResponseFour>(_httpMethodGet, "/api/users/23"));

            Task.Run(async () => await _requests.SendAsync<ResponseOne>(_httpMethodGet, "/api/unknown"));

            Task.Run(async () => await _requests.SendAsync<ResponseTwo>(_httpMethodGet, "/api/unknown/2"));

            Task.Run(async () => await _requests.SendAsync<ResponseTwo>(_httpMethodGet, "/api/unknown/23"));

            var payloadOne = new RequestThree { Name = "morpheus", Job = "leader" };

            Task.Run(async () => await _requests.SendAsync<ResponseThree>(_httpMethodPost, "/api/users", payloadOne));

            var payloadTwo = new RequestThree { Name = "morpheus", Job = "zion resident" };

            Task.Run(async () => await _requests.SendAsync<ResponseThree>(_httpMethodPut, "/api/users/2", payloadTwo));

            Task.Run(async () => await _requests.SendAsync<ResponseThree>(_httpMethodPatch, "/api/users/2", payloadTwo));

            Task.Run(async () => await _requests.SendAsync<ResponseThree>(_httpMethodDelete, "/api/users/2"));

            var payloadThree = new RequestFour { Email = "eve.holt@reqres.in", Password = "pistol" };

            Task.Run(async () => await _requests.SendAsync<ResponseFour>(_httpMethodPost, "/api/register", payloadThree));

            var payloadFour = new RequestFour { Email = "sydney@fife" };

            Task.Run(async () => await _requests.SendAsync<ResponseFour>(_httpMethodPost, "/api/register", payloadFour));

            var payloadSix = new RequestFour { Email = "eve.holt@reqres.in", Password = "cityslicka" };

            Task.Run(async () => await _requests.SendAsync<ResponseFour>(_httpMethodPost, "/api/login", payloadSix));

            var payloadSaven = new RequestFour { Email = "peter@klaven" };

            Task.Run(async () => await _requests.SendAsync<ResponseFour>(_httpMethodPost, "/api/login", payloadSaven));

            Task.Run(async () => await _requests.SendAsync<ResponseOne>(_httpMethodGet, "/api/users?delay=3"));
        }
    }
}
