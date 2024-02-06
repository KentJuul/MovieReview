using MovieReview.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReview.Data.Interfaces
{
    public interface IReviewRepository
    {
        List<Review> GetAllReviews();
    }
}
