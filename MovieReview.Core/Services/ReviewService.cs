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
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository; 
        }
        public List<Review> GetAllReviews()
        {
            return _reviewRepository.GetAllReviews();
        }
    }
}
