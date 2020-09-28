using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RottenTomatoes.Models
{
    public class Movie
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("mpaa_rating")]
        public string MpaaRating { get; set; }

        [JsonProperty("runtime")]
        public int Runtime { get; set; }

        [JsonProperty("critics_consensus")]
        public string CriticsConsensus { get; set; }

        [JsonProperty("release_dates")]
        public ReleaseDate ReleaseDates { get; set; }

        [JsonProperty("ratings")]
        public Rating Ratings { get; set; }

        [JsonProperty("synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty("posters")]
        public Poster Posters { get; set; }

        [JsonProperty("abridged_cast")]
        public List<AbridgedCast> AbridgedCast { get; set; }

        [JsonProperty("links")]
        public Link Links { get; set; }
    }
}