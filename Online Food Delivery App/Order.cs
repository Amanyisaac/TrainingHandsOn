using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
    public class Order
    {
        public String OrderID { get; set; }
        public String RestaurantName { get; set; }
        public String FoodItem { get; set; }
        public String DeliveryAddress { get; set; }
         public DateTime OrderTime { get; set; }
        List<Review> Reviews { get; set; } = new List<Review>();
         public Order(String orderID, String restaurantName, String foodItem, String deliveryAddress, DateTime orderTime)
        {
            OrderID = orderID;
            RestaurantName = restaurantName;
            FoodItem = foodItem;
            DeliveryAddress = deliveryAddress;
             OrderTime = orderTime;
        }
    }
}
