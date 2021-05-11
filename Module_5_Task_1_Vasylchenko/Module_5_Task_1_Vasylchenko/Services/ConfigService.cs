using System.IO;
using Module_5_Task_1_Vasylchenko.Models;
using Module_5_Task_1_Vasylchenko.Services.InterfaceServisec;
using Newtonsoft.Json;

namespace Module_5_Task_1_Vasylchenko.Services
{
    public class ConfigService : IConfigService
    {
        private const string _pathToJsonFile = "config.json";

        public Config ReturnConfig()
        {
            var fs = File.ReadAllText(_pathToJsonFile);
            var config = JsonConvert.DeserializeObject<Config>(fs);
            return config;
        }
    }
}
