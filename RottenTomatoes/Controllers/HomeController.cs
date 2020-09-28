using Newtonsoft.Json;
using RottenTomatoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RottenTomatoes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Net.WebClient client = new System.Net.WebClient();
            string a = client.DownloadString("https://www.rottentomatoes.com/api/private/v1.0/movies?page_limit=10&page=1&q=a");

            dynamic m = JsonConvert.DeserializeObject<object>(a);
            var m2 = m["movies"];
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}