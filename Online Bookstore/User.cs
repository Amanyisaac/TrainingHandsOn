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
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Address { get; private set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }
        public string Id { get; private set; }

        public User(String name, String email, String phonenumber, String address, int age, String gender, String id)
        {
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phonenumber;
            this.Address = address;
            this.Age = age;
            this.Gender = gender;
            this.Id = id;


        }
    }

}







