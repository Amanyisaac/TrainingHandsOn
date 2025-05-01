using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
    public class Restaurant
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Hotline { get; set; }
        public String Email { get; set; }
         public List<Menu> Menu { get; set; }
        public List<Review> Reviews { get; set; }
        public Restaurant(int id,String name, String address, String hotline, String email)
        {

            Id = id;
            Name = name;
            Address = address;
            Hotline = hotline;
            Email = email;
             Menu = new List<Menu>();
            Reviews = new List<Review>();
        }

    }
}
