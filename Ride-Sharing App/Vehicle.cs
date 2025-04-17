using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    public class Vehicle
    {
        public String VehicleType { get; set; }
        public String VehicleModel { get; set; }
        public String VehicleNumber { get; set; }
        public String VehicleColor { get; set; }

        public Vehicle(String vehicletype, String vehiclemodel, String vehiclenumber, String vehiclecolor)
        {
            VehicleType = vehicletype;
            VehicleModel = vehiclemodel;
            VehicleNumber = vehiclenumber;
            VehicleColor = vehiclecolor;

        }
    }
}
