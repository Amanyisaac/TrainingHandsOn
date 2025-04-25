using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
    public class User
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public String Address { get; set; }
        public String PasswordOfoAccount { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
        public User(String id, String name, String email, String phoneNumber, String passwordOfoAccount, String address)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            PasswordOfoAccount = passwordOfoAccount;
            Reviews = new List<Review>();
            Orders = new List<Order>();

        }
    }
}
