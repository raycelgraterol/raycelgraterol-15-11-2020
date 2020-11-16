using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BertoniServices.Entities
{
    public class Album
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
