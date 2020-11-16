using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BertoniServices.Entities
{
    public class Comment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("comment")]
        public string Messsage { get; set; }

        public int PhotoId { get; set; }
    }
}
