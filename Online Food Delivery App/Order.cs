namespace Online_Food_Delivery_App
{
    public class Order
    {
        public String OrderID { get; set; }
        public String RestaurantName { get; set; }
        public String FoodItem { get; set; }

        public String DeliveryAddress { get; set; }
        public DateTime OrderTime { get; set; }
        public OrderStatus Status { get; set; }

        public Order(String orderID, String restaurantName, String foodItem,
                     String deliveryAddress, DateTime orderTime, OrderStatus status)
        {
            OrderID = orderID;
            RestaurantName = restaurantName;
            FoodItem = foodItem;
            DeliveryAddress = deliveryAddress;
            OrderTime = orderTime;
            Status = status;
        }

        public enum OrderStatus
        {
            Pending,
            InProgress,
            Delivered,
            Cancelled
        }
    }
}
