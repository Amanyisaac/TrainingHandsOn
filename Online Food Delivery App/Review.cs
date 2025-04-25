using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
    public class Review
    {
        public String UserName { get; set; }
        public String RestaurantName { get; set; }
        public int Rating { get; set; }
        public String Comment { get; set; }

        public Review(String username, String restaurantname, int rating, String comment)
        {
            UserName = username;
            RestaurantName = restaurantname;
            Rating = rating;
            Comment = comment;
        }
    }
}
