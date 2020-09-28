using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RottenTomatoes.Models
{
    public class Poster
    {
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("detailed")]
        public string Detailed { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }
    }
}