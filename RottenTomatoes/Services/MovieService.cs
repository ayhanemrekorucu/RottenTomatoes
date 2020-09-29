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

        internal MovieResult GetMoviesByFilter(string filter, int page = 1)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString(apiUrl + "movies?page_limit=6&page=" + page + "&q=" + filter);
            MovieResult result = JsonConvert.DeserializeObject<MovieResult>(json);
            return result;
        }

        internal Movie GetMovieDetails(int id)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString(apiUrl + "movies/" + id);
            Movie result = JsonConvert.DeserializeObject<Movie>(json);
            return result;
        }

        internal List<Movie> GetBoxOfficeMovies(string country, int pageLimit)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString(apiUrl + "movies/box_office?limit=" + pageLimit + "&country=" + country);
            MovieResult result = JsonConvert.DeserializeObject<MovieResult>(json);
            return result.Movies;
        }
    }
}