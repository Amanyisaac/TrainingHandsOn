using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
    public class Notifications
    {
        public String NotificationMessage { get; set; }
        public DateTime NotificationTime { get; set; }

        public Notifications(String notificationmessage, DateTime notificationtime)
        {
            NotificationMessage = notificationmessage;
            NotificationTime = notificationtime;
        }

        
    }
}
