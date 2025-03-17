using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore
{
    public class Order
    {
        private string name;
        private string address;
        private string email;
        private string phonenumber;
        User user;

        public Order(string name, string address, string email, string phonenumber, User user)
        {
            this.name = name;
            this.address = address;
            this.email = email;
            this.phonenumber = phonenumber;
            this.user = user;
        }
    }
}
