using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
 using MyBookStore;
using System.Net;
using System.Xml.Linq;
 
namespace MyBookStore
{
    public class Order
    {
        private string address;
        private User user;

        public Order(string address, User user)
        {
            this.address = address;
            this.user = user;
        }

        public void SetAddress(string a)
        {
            address = a;
        }

        public string GetAddress()
        {
            return address;
        }

        public User GetUser()
        {
            return user;
        }

        public void SetUser(User u)
        {
            user = u;
        }

        public void display_info()
        {
            Console.WriteLine("Order Address: " + address);
            Console.WriteLine("User Name: " + user.GetName());
            Console.WriteLine("User Age: " + user.GetAge());
            Console.WriteLine("User Number: " + user.GetNumber());
            Console.WriteLine("User Email: " + user.GetEmail());
        }
    }
}
