using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
 
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public String Address { get; set; }
        public String PasswordOfoAccount { get; set; }
         List<Ride> rides = new List<Ride>();
        public Review Review { get; set; }

        public User(int id, String name, String email, String phoneNumber, String passwordOfoAccount, String address,Review review )
        {

            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            PasswordOfoAccount = passwordOfoAccount;
            rides = new List<Ride>();
            Review = review;

        }
    }
}
