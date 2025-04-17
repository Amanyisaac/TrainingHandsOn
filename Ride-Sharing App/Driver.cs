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

        public String LicenseNumber { get; set; }
        public Vehicle Vehicle { get; set; }
        List<Ride> rides;
            public Driver(int id, String name, String email, String phoneNumber, String passwordOfoAccount,
                String address, String licensenumber, Vehicle vehicle ) :
                base(id, name, email, phoneNumber, passwordOfoAccount, address )
        {

                LicenseNumber = licensenumber;
                Vehicle = vehicle;
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
