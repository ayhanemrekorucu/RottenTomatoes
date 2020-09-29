using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RottenTomatoes.Models
{
    public class Cast
    {

        [JsonProperty("creators")]
        public IList<object> Creators { get; set; }

        [JsonProperty("castItems")]
        public IList<CastItem> CastItems { get; set; }
    }
}