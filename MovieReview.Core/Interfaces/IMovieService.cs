using MovieReview.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReview.Core.Interfaces
{
    public interface IMovieService
    {
        Movie CreateMovie(Movie movie);
        List<Movie> GetAllMovies();
    }
}
