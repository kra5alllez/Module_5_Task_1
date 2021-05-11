using Newtonsoft.Json;

namespace Module_5_Task_1_Vasylchenko.Models.ModelsThree
{
    public class RequestThree
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }
    }
}
