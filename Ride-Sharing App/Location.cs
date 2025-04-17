using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    public class Location
    {
         public String StartLocation { get; set; }
        public String EndLocation { get; set; }

        public Location( String startlocation, String endlocation)
        {
           
            StartLocation = startlocation;
            EndLocation = endlocation;

        }
    }
}

 
