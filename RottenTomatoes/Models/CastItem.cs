using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RottenTomatoes.Models
{
    public class CastItem
    {

        [JsonProperty("person")]
        public Person Person { get; set; }
    }
}