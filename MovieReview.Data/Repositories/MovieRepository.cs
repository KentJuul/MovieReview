using MovieReview.Core.Entity;
using MovieReview.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReview.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {

        public List<Movie> GetAllMovies()
        {
            return FakeDB.movies;
        }
    }
}
