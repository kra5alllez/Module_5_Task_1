using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Module_5_Task_1_Vasylchenko.Models.ModelsOne
{
    public class UsersOne
    {
        public int Id { get; set; }
        public string Email { get; set; }

        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
        public string Avatar { get; set; }
    }
}
