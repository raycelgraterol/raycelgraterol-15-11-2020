using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BertoniServices.Entities
{
    public class Photo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        public string Title { get; set; }

        [JsonProperty("path")]
        public string PhotoPath { get; set; }

        public int AlbumId { get; set; }
    }
}
