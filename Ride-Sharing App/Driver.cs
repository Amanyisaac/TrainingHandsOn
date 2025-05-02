using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{

    public class Driver : User
    {

         public List<Payment> Payments { get; set; }     
        public Vehicle Vehicle { get; set; }
        public Location Location { get; set; }
        public List<Ride> rides;
         public Driver(int id , String name, String email, String phoneNumber, String passwordOfoAccount,
                String address,  Vehicle vehicle , Review review , Location location , Payment payment) :
                base(id ,name, email, phoneNumber, passwordOfoAccount, address , review )
        {

            Payments = new List<Payment>();
            Vehicle = vehicle;
                 Location = location;
              rides = new List<Ride>();
 


        }
        public string StateOfRide(string state)
            {
                if (state == "Accept" || state == "Reject")
                {
                    return state;
                }
                return "Invalid";
            }
        }
    }
