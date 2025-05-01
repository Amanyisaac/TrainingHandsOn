using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
    public class Review
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public String RestaurantName { get; set; }
        public int Rating { get; set; }
        public String Comment { get; set; }
        public Customer Payer { get; set; }
        public Customer Payee { get; set; }


        public Review(int id, String username, String restaurantname, int rating, String comment, Customer payer, Customer payee)
        {
            Id = id;
            UserName = username;
            RestaurantName = restaurantname;
            Rating = rating;
            Comment = comment;
            Payer = payer;
            Payee = payee;
        }
    }
}
