using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RottenTomatoes.Models
{
    public class ReleaseDate
    {
        [JsonProperty("theater")]
        public string Theater { get; set; }

        [JsonProperty("dvd")]
        public string Dvd { get; set; }
    }
}