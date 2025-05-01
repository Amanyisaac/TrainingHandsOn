using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Online_Food_Delivery_App
{
    public class Rating
    {
        public int Id { get; set; }
        public int RatingValue { get; set; }
        public DateTime ReviewDate { get; set; }
        public Customer Rater { get; set; }
        public Customer Rated { get; set; }


        public Rating(int id, int ratingValue, DateTime reviewDate, Customer rater, Customer rated)
        {
            Id = id;
            RatingValue = ratingValue;
            ReviewDate = reviewDate;
            Rater = rater;
            Rated = rated;
        }
    }
}