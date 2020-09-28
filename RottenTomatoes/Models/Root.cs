using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RottenTomatoes.Models
{
    public class Root
    {
        public int total { get; set; }
        public List<Movie> Movies { get; set; }
        public int MyProperty { get; set; }
    }
}