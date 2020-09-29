using Newtonsoft.Json;
using RottenTomatoes.Models;
using RottenTomatoes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RottenTomatoes.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index(string searchQuery, int page = 1)
        {
            MovieResult result = new MovieResult();
            result.RecentSearches = GetRecentKeysCookie();
            if (!string.IsNullOrEmpty(searchQuery))
            {
                SetCookieItem(searchQuery);

                MovieService service = new MovieService();
                var mr = service.GetMoviesByFilter(searchQuery, page);
                result.Movies = mr.Movies;
                result.Total = mr.Total;

                return View(result);
            }
            return View(result);
        }

        public ActionResult Detail(int id)
        {
            MovieService service = new MovieService();
            var a = service.GetMovieDetails(id);
            return View(service.GetMovieDetails(id));
        }

        private List<string> GetRecentKeysCookie()
        {
            HttpCookie cookie = Request.Cookies["Recent5Keys"];
            List<string> list = null;
            if (cookie != null && cookie["list"] != null)
            {
                list = JsonConvert.DeserializeObject<List<string>>(cookie["list"]);
            }
            return list;
        }

        private void SetCookieItem(string val)
        {
            HttpCookie cookie = Request.Cookies["Recent5Keys"];
            List<string> list = null;
            if (cookie["list"] == null)
            {
                cookie = Response.Cookies["Recent5Keys"];
                list = new List<string>();
            }
            else
            {
                list = JsonConvert.DeserializeObject<List<string>>(cookie["list"]);
                cookie = Response.Cookies["Recent5Keys"];
            }

            if (list.Count == 5)
                list.RemoveAt(0);
            if (!list.Contains(val))
                list.Add(val);

            cookie["list"] = JsonConvert.SerializeObject(list);
            Response.Cookies.Add(cookie);
        }
    }
}