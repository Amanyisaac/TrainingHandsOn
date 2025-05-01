using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
    public class Notifications
    {
        public int Id { get; set; }
        public String NotificationMessage { get; set; }
        public DateTime NotificationTime { get; set; }

        public Notifications(int id ,String notificationmessage, DateTime notificationtime)
        {
            Id = id;
            NotificationMessage = notificationmessage;
            NotificationTime = notificationtime;
        }

        
    }
}
