using Module_5_Task_1_Vasylchenko.Models;

namespace Module_5_Task_1_Vasylchenko.Services.InterfaceServisec
{
    public interface IConfigService
    {
        const string _pathToJsonFile = "config.json";
        Config ReturnConfig();
    }
}
