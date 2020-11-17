using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BertoniServices.Entities
{
    public class Photo
    {
        [JsonProperty("albumId")]
        public int AlbumId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string PhotoPath { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string Thumbnail { get; set; }

        /*
        "albumId": 1,
        "id": 1,
        "title": "accusamus beatae ad facilis cum similique qui sunt",
        "url": "https://via.placeholder.com/600/92c952",
        "thumbnailUrl": "https://via.placeholder.com/150/92c952"
         */
    }
}
