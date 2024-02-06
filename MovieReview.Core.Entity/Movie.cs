using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReview.Core.Entity
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string? Title { get; set; }
        public string? Director { get; set; }
        public int ReleaseYear { get; set; }
        public List<string>? Genres { get; set; }
        public List<string>? Cast { get; set; }
        public string? Synopsis { get; set; }
        public float Rating { get; set; }
        public int Runtime { get; set; }
        public string? Language { get; set; }
        public string? ImageUrl { get; set; }
        public List<Review>? Reviews { get; set; }
    }
}