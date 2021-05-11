using System;
using System.Net;
using Module_5_Task_1_Vasylchenko.Services.InterfaceServisec;

namespace Module_5_Task_1_Vasylchenko.Services
{
    public class LoggerService : ILoggerService
    {
        public void LogSucces(HttpStatusCode massage)
        {
            Console.WriteLine($"Success message : {massage}");
        }

        public void LogError(HttpStatusCode massage)
        {
            Console.WriteLine($"Error message : {massage}");
        }
    }
}
