using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    public class Notification
    {
        public String NotificationType { get; set; }
         public DateTime NotificationTime { get; set; }
        public String NotificationStatus { get; set; }
       
        public Notification(String notificationtype, DateTime notificationtime, String notificationstatus)
        {
            NotificationType = notificationtype;
             NotificationTime = notificationtime;
            NotificationStatus = notificationstatus;

        }
    }
 }
