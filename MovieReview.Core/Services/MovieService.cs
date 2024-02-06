using MovieReview.Core.Entity;
using MovieReview.Core.Interfaces;
using MovieReview.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReview.Core.Services
{
    public class MovieService : IMovieService
    {
        public readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
                _movieRepository = movieRepository;
        }
        public List<Movie> GetAllMovies()
        {
            return FakeDB.Movies();
        }
    }
}
