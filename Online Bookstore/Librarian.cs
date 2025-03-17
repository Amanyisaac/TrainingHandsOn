using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore
{
    public class Librarian
    {
        private String name;
        private int age;    
        private int phonenumber;
        private String email;
        private String address;

        public Librarian(string name, int age, int phonenumber, string email, string address)
        {
            this.name = name;
            this.age = age;
            this.phonenumber = phonenumber;
            this.email = email;
            this.address = address;
        }


    }
}
