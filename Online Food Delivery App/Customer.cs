using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_App
{
    public class Customer : User
    {
        public List<Order> Orders { get; set; }
        public List<Notifications> Notifications { get; set; }
        public List<Location> Locations { get; set; }
        public Menu Menu { get; set; }

        public Customer(int id, String name, String email, String phoneNumber, String passwordOfoAccount,
            String address ,Menu menu) : base(id, name, email, phoneNumber, passwordOfoAccount, address)
        {
            Orders = new List<Order>();
            Notifications = new List<Notifications>();
            Locations = new List<Location>();
            Menu = menu;
        }
    }
}
