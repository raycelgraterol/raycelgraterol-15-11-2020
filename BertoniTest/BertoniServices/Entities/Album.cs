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

        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Name { get; set; }
    }
}
