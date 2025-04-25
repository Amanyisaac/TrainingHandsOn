using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
    public class DeliveryTracker
    {
        public String DeliveryStatus { get; set; }
        public String DeliveryTime { get; set; }
        public String DeliveryLocation { get; set; }
        public String DeliveryPersonName { get; set; }
        public String DeliveryPersonContact { get; set; }
        List<Location> locationHistory = new List<Location>();
         List<Order> orderHistory = new List<Order>();
        public DeliveryTracker(String deliveryStatus, String deliveryTime, String deliveryLocation, String deliveryPersonName, String deliveryPersonContact)
        {
            DeliveryStatus = deliveryStatus;
            DeliveryTime = deliveryTime;
            DeliveryLocation = deliveryLocation;
            DeliveryPersonName = deliveryPersonName;
            DeliveryPersonContact = deliveryPersonContact;
        }
    }
}
