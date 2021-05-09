using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Module_5_Task_1_Vasylchenko.Models;
using Module_5_Task_1_Vasylchenko.Models.ModelsFour;
using Module_5_Task_1_Vasylchenko.Models.ModelsOne;
using Module_5_Task_1_Vasylchenko.Models.ModelsThree;
using Module_5_Task_1_Vasylchenko.Models.ModelsTwo;
using Module_5_Task_1_Vasylchenko.Services;

namespace Module_5_Task_1_Vasylchenko
{
    public class Starter
    {
        public async Task Run()
        {
            var r = new RequestsService();
            var httpStatusOk = HttpStatusCode.OK;
            var methodGet = HttpMethod.Get;
            await r.SendAsync<ResponseOne>(httpStatusOk, methodGet, "https://reqres.in/api/users?page=2");

            await r.SendAsync<ResponseTwo>(httpStatusOk, methodGet, "https://reqres.in/api/users/2");

            await r.SendAsync<ResponseFour>(httpStatusOk, methodGet, "https://reqres.in/api/users/23");

            await r.SendAsync<ResponseOne>(httpStatusOk, methodGet, "https://reqres.in/api/unknown");

            await r.SendAsync<ResponseTwo>(httpStatusOk, methodGet, "https://reqres.in/api/unknown/2");

            await r.SendAsync<ResponseTwo>(httpStatusOk, methodGet, "https://reqres.in/api/unknown/23");

            httpStatusOk = HttpStatusCode.Created;
            methodGet = HttpMethod.Post;
            var payloadOne = new
            {
                name = "morpheus",
                job = "leader"
            };

            await r.SendAsync<ResponseThree>(httpStatusOk, methodGet, "https://reqres.in/api/users", payloadOne);

            httpStatusOk = HttpStatusCode.OK;
            methodGet = HttpMethod.Put;
            var payloadTwo = new
            {
                name = "morpheus",
                job = "zion resident"
            };

            await r.SendAsync<ResponseThree>(httpStatusOk, methodGet, "https://reqres.in/api/users/2", payloadTwo);

            methodGet = HttpMethod.Patch;
            await r.SendAsync<ResponseThree>(httpStatusOk, methodGet, "https://reqres.in/api/users/2", payloadTwo);

            methodGet = HttpMethod.Delete;
            await r.SendAsync<ResponseThree>(httpStatusOk, methodGet, "https://reqres.in/api/users/2");

            methodGet = HttpMethod.Post;
            var payloadThree = new
            {
                email = "eve.holt@reqres.in",
                password = "pistol"
            };

            await r.SendAsync<ResponseFour>(httpStatusOk, methodGet, "https://reqres.in/api/register", payloadThree);

            httpStatusOk = HttpStatusCode.BadRequest;
            var payloadFour = new
            {
                email = "sydney@fife",
            };

            await r.SendAsync<ResponseFour>(httpStatusOk, methodGet, "https://reqres.in/api/register", payloadFour);

            httpStatusOk = HttpStatusCode.OK;
            var payloadSix = new
            {
                email = "eve.holt@reqres.in",
                password = "cityslicka"
            };

            await r.SendAsync<ResponseFour>(httpStatusOk, methodGet, "https://reqres.in/api/login", payloadSix);

            httpStatusOk = HttpStatusCode.BadRequest;
            var payloadSaven = new
            {
                email = "eve.holt@reqres.in",
            };

            await r.SendAsync<ResponseFour>(httpStatusOk, methodGet, "https://reqres.in/api/login", payloadSaven);

            httpStatusOk = HttpStatusCode.OK;
            methodGet = HttpMethod.Get;
            await r.SendAsync<ResponseOne>(httpStatusOk, methodGet, "https://reqres.in/api/users?delay=3");
        }
    }
}
