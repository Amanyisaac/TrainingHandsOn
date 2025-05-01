using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    public class Ride
    {
        public int Id { get; set; }
        public String RideType { get; set; } 
        public String RideStatus { get; set; }  
        public DateTime RideDateTime { get; set; }
        public Location Take_offLocation { get; set; } 
       public Location DropLocation { get; set; }
        public double RideCost { get; set; }
       public Driver Driver { get; set; }
        public Passenger Passenger { get; set; }

        public Ride(int id, String ridetype, String ridestatus, DateTime ridedatetime,Location take_offLocation,Location dropLocation,
            double ridecost , Driver driver,Passenger passenger)
        {
            Id = id;
            RideType = ridetype;
            RideStatus = ridestatus;
            RideDateTime = ridedatetime;
             RideCost = ridecost;
            Take_offLocation = take_offLocation;
            DropLocation = dropLocation;
            Driver = driver;
            Passenger = passenger;
        }
    }
}







