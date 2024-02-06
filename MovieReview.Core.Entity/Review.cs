using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReview.Core.Entity
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int MovieID { get; set; }
        public string? Author { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime Date { get; set; }
    }
}
