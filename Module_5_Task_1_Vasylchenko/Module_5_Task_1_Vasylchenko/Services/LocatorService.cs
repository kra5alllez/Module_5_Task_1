using Module_5_Task_1_Vasylchenko.Services.InterfaceServisec;

namespace Module_5_Task_1_Vasylchenko.Services
{
    public class LocatorService
    {
        public static ILoggerService LoggerService => new LoggerService();
        public static IConfigService ConfigService => new ConfigService();

        public static IRequestsService RequestsService => new RequestsService();
    }
}
