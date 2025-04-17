using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    public class Review
    {
        public String ReviewText { get; set; }
        public int RatingValue { get; set; }
        public DateTime ReviewDate { get; set; }
        public DateTime ReviewTime { get; set; }
        public String ReviewStatus { get; set; }
        public Review(String reviewtext, int ratingvalue, DateTime reviewdate, DateTime reviewtime, String reviewstatus)
        {
            ReviewText = reviewtext;
            RatingValue = ratingvalue;
            ReviewDate = reviewdate;
            ReviewTime = reviewtime;
            ReviewStatus = reviewstatus;

        }
    }
}
