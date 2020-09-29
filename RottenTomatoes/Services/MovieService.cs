using Newtonsoft.Json;
using RottenTomatoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace RottenTomatoes.Services
{
    public class MovieService
    {
        private readonly string apiUrl = "https://www.rottentomatoes.com/api/private/v1.0/";

        internal List<Movie> GetMoviesByFilter(string filter, int page = 1)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString(apiUrl + "movies?page_limit=6&page=" + page + "&q=" + filter);
            Root root = JsonConvert.DeserializeObject<Root>(json);
            return root.Movies;
        }

        internal Movie GetMovieDetails(int id)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString(apiUrl + "movies/" + id);
            Root root = JsonConvert.DeserializeObject<Root>(json);
            return root.Movies.FirstOrDefault();
        }

        internal List<Movie> GetBoxOfficeMovies(string country, int pageLimit)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString(apiUrl + "movies/box_office?limit=" + pageLimit + "&country=" + country);
            Root root = JsonConvert.DeserializeObject<Root>(json);
            return root.Movies;
        }
    }
}