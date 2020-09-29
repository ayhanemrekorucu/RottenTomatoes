using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RottenTomatoes.Models
{
    public class MovieResult
    {
        [JsonProperty("movies")]
        public List<Movie> Movies { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        public List<string> RecentSearches { get; set; }
    }
}