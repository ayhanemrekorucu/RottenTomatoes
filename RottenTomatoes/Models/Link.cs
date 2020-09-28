using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RottenTomatoes.Models
{
    public class Link
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("alternate")]
        public string Alternate { get; set; }

        [JsonProperty("cast")]
        public string Cast { get; set; }

        [JsonProperty("reviews")]
        public string Reviews { get; set; }

        [JsonProperty("similar")]
        public string Similar { get; set; }
    }
}