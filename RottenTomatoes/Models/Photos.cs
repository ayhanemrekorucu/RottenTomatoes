using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RottenTomatoes.Models
{
    public class Photos
    {
        [JsonProperty("photos")]
        public IList<Photo> PhotoList { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }
    }
}