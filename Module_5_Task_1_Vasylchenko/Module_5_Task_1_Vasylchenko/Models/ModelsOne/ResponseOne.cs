using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Module_5_Task_1_Vasylchenko.Models.ModelsOne
{
    public class ResponseOne
    {
        public int Page { get; set; }

        [JsonProperty(PropertyName = "per_page")]
        public int PerPage { get; set; }
        public int Total { get; set; }

        [JsonProperty(PropertyName = "total_pages")]
        public int TotalPages { get; set; }
        public List<UsersOne> Data { get; set; }
        public SupportOne Support { get; set; }
    }
}
