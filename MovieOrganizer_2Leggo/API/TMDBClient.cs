using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Client;

namespace MovieOrganizer_2Leggo.API
{
    class TMDBClient
    {
        TMDbClient client = new TMDbClient("7eafcdf2b8afbcabf4af23691c45c132");

        /// <summary>
        /// Gets the movie based on the given movie name
        /// </summary>
        /// <param name="title">the name of the movie</param>
        /// <returns>the movie object</returns>
        public List<TMDbLib.Objects.Search.SearchMovie> GetMovieByTitle(string title)
        {
                return client.SearchMovie(title).Results;     
        }



    }
}
