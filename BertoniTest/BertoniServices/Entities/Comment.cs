using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BertoniServices.Entities
{
    public class Comment
    {
        [JsonProperty("postId")]
        public int PhotoId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("body")]
        public string Messsage { get; set; }

        
    }
}


/*
 * "postId": 1,
    "id": 1,
    "name": "id labore ex et quam laborum",
    "email": "Eliseo@gardner.biz",
    "body": "laudantium enim quasi est quidem magnam voluptate ipsam eos\ntempora quo necessitatibus\ndolor quam autem quasi\nreiciendis et nam sapiente accusantium"
 */
