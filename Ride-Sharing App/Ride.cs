using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    public class Ride
    {
        public int RideId { get; set; }
        public String RideType { get; set; } 
        public String RideStatus { get; set; }  
        public DateTime RideDateTime { get; set; }
        public String StartLocation { get; set; }  
        public String EndLocation { get; set; }  
        public double RideCost { get; set; }

         
        public Ride(int rideid, String ridetype, String ridestatus, DateTime ridedatetime, String startlocation, String endlocation, double ridecost)
        {
            RideId = rideid;
            RideType = ridetype;
            RideStatus = ridestatus;
            RideDateTime = ridedatetime;
            StartLocation = startlocation;
            EndLocation = endlocation;
            RideCost = ridecost;
        }
    }
}