using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PddAdmin.Models
{
    public partial class Responses
    {
        public int Id { get; set; }
        public string Response { get; set; }
        public bool IsRight { get; set; }
        public int QueryId { get; set; }

        [JsonIgnore]
        public virtual QueryItem Query { get; set; }
    }
}
