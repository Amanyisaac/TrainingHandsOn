using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore
{
    public class User
    { 
        private String name;
        private int email;
        private int phonenumber;
        private String address;


        public User(string name, int email, int phonenumber, string address)
        {
            this.name = name;
            this.email = email;
            this.phonenumber = phonenumber;
            this.address = address;
        }
    }
}
