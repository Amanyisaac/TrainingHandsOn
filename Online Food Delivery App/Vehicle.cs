using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
    public class Vehicle
    {
      
        public String VehicleType { get; set; }
        public String VehicleNumber { get; set; }
        public String VehicleModel { get; set; }
        public String VehicleColor { get; set; }
        public Vehicle(String vehicleType, String vehicleNumber, String vehicleModel, String vehicleColor)
        {
            VehicleType = vehicleType;
            VehicleNumber = vehicleNumber;
            VehicleModel = vehicleModel;
            VehicleColor = vehicleColor;
        }
    }
}
