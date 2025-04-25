using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
    public class PersonOfDelivery : User
    {
        public String VehicleType { get; set; }
        public String VehicleNumber { get; set; }
        public String VehicleModel { get; set; }
        public String VehicleColor { get; set; }
        public List<Notifications> Notifications { get; set; }
        public List<Location> Locations { get; set; }

        public PersonOfDelivery(String id, String name, String email, String phoneNumber, String passwordOfoAccount,
            String address, String vehicleType, String vehicleNumber, String vehicleModel, String vehicleColor) :
            base(id, name, email, phoneNumber, passwordOfoAccount, address)
        {
            VehicleType = vehicleType;
            VehicleNumber = vehicleNumber;
            VehicleModel = vehicleModel;
            VehicleColor = vehicleColor;
            Notifications = new List<Notifications>();
            Locations = new List<Location>();
        }
    }
}
