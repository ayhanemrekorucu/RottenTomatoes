﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RottenTomatoes.Models
{
    public class Rating
    {
        [JsonProperty("critics_rating")]
        public string CriticsRating { get; set; }

        [JsonProperty("critics_score")]
        public int CriticsScore { get; set; }

        [JsonProperty("audience_rating")]
        public string AudienceRating { get; set; }

        [JsonProperty("audience_score")]
        public int AudienceScore { get; set; }
    }
}