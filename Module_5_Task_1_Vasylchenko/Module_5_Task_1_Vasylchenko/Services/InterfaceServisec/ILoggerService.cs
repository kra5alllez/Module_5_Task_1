using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_Task_1_Vasylchenko.Services.InterfaceServisec
{
    public interface ILoggerService
    {
        void LogSucces(HttpStatusCode massage);
        void LogError(HttpStatusCode massage);
    }
}
