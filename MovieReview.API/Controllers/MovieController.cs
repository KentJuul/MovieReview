using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieReview.Core.Entity;
using MovieReview.Core.Interfaces;

namespace MovieReview.API.Controllers
{
    [Route("movies")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public ActionResult GetAll() 
        {
            try
            {
                return Ok(_movieService.GetAllMovies());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
               
        }

    }
}
