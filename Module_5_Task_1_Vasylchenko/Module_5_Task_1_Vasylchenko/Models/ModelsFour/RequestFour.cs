using Newtonsoft.Json;

namespace Module_5_Task_1_Vasylchenko.Models.ModelsFour
{
    public class RequestFour
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
