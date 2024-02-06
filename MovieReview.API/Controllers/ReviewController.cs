using Microsoft.AspNetCore.Mvc;
using MovieReview.Core.Interfaces;
using MovieReview.Core.Services;

namespace MovieReview.API.Controllers
{
    [Route("reviews")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _IReviewService; 
        public ReviewController(IReviewService reviewService)
        {
            _IReviewService = reviewService;
        }

        [HttpGet]
        public ActionResult GetAllReviews()
        {
            try
            {
                return Ok(_IReviewService.GetAllReviews());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
