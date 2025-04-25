using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
    public class Restaurant
    {
         public String Name { get; set; }
        public String Address { get; set; }
        public String Hotline { get; set; }
        public String Email { get; set; }
        public String TypeOfRestaurant { get; set; }
        public List<Menu> Menu { get; set; }
        public List<Review> Reviews { get; set; }
        public Restaurant(String name, String address, String hotline, String email, String typeOfRestaurant)
        {
             
            Name = name;
            Address = address;
            Hotline = hotline;
            Email = email;
            TypeOfRestaurant = typeOfRestaurant;
            Menu = new List<Menu>();
            Reviews = new List<Review>();
        }

    }
}
