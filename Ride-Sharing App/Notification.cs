using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App
{
    public class Notification
    { 
        public int Id { get; set; }
         public String NotificationType { get; set; }
         public DateTime NotificationTime { get; set; }
        public String NotificationStatus { get; set; }
        public Driver Driver { get; set; }
        public Passenger Passenger { get; set; }

        public Notification(int id,String notificationtype, DateTime notificationtime, String notificationstatus, Driver driver,Passenger passenger)
        {
            Id = id;
            NotificationType = notificationtype;
            NotificationTime = notificationtime;
            NotificationStatus = notificationstatus;
             Passenger = passenger;
            Driver = driver;



        }
    }
 }
