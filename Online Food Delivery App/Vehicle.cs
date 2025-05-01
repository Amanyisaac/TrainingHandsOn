using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    public class Vehicle
    {
        public int Id { get; set; }
        public String LicenseNumber { get; set; }
        public String VehicleType { get; set; }
        public String VehicleModel { get; set; }
        public String VehicleNumber { get; set; }
        public String VehicleColor { get; set; }

        public Vehicle(int id, String licenseNumber, String vehicletype, String vehiclemodel, String vehiclenumber, String vehiclecolor)
        {
            Id = id;
            LicenseNumber = licenseNumber;
            VehicleType = vehicletype;
            VehicleModel = vehiclemodel;
            VehicleNumber = vehiclenumber;
            VehicleColor = vehiclecolor;

        }
    }
}