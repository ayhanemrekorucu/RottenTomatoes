using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RottenTomatoes.Models
{
    public class Root
    {
        [JsonProperty("movies")]
        public List<Movie> Movies { get; set; }
    }
}