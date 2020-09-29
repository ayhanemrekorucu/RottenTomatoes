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
            if (!string.IsNullOrEmpty(searchQuery))
            {
                MovieService service = new MovieService();
                return View(service.GetMoviesByFilter(searchQuery, page));
            }
            return View();
        }
    }
}