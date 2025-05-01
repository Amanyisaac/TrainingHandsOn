using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
 
    public class Location
{
        public int Id { get; set; }
        public String Longitude { get; set; }
        public String Latitude { get; set; }
        public Location(int id, String longitude, String latitude)
        {
            Id = id;
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
