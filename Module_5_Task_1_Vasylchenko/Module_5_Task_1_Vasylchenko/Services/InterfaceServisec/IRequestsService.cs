using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_Task_1_Vasylchenko.Services.InterfaceServisec
{
    public interface IRequestsService
    {
        Task<T> SendAsync<T>(HttpMethod httpMethod, string linkTwo, object obj = null);
    }
}
