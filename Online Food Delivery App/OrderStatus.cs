using System;

namespace Online_Food_Delivery_App
{
    public class OrderStatus : Order
    {
        public String Status { get; set; } 
       

        public OrderStatus(String orderID, String restaurantName, String foodItem, String deliveryAddress,
            DateTime orderTime, String orderStatus)
            : base(orderID, restaurantName, foodItem, deliveryAddress, orderTime)
        {
            Status = orderStatus;
        }
    }
}
