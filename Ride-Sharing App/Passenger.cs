using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    public class Passenger : User

    {
 
       public List<Payment> Payments { get; set; }//Payments made by the passenger
        public List<Notification> Notifications { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Ride> Rides { get; set; }
        public Location Location { get; set; }              
        public Passenger(int id, String name, String email, String phoneNumber, String 
            passwordOfoAccount, String address, Review review, Location location   )
            : base(id, name, email, phoneNumber, passwordOfoAccount, address, review)
        {

            Payments = new List<Payment>();
            Notifications = new List<Notification>();
            Ratings = new List<Rating>();
            Reviews = new List<Review>();
            Rides = new List<Ride>();
            Location = location;
        }

    }
}

