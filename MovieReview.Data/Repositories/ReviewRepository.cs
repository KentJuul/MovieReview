using MovieReview.Core.Entity;
using MovieReview.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReview.Data.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        public List<Review> GetAllReviews()
        {
            return FakeDB.reviews;
        }
    }
}
