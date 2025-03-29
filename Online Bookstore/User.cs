using Online_Bookstore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Online_Bookstore
{


    public class User
    {
        private String name;
        private string email;
        private string phonenumber;
        private String address;
        private int age;
        private string gender;
        public string id;
        public User(string name, string email, string phonenumber, string address, int age, string gender, string id)
        {
            this.name = name;
            this.email = email;
            this.phonenumber = phonenumber;
            this.address = address;
            this.age = age;
            this.gender = gender;
            this.id = id;


        }
    }

}







