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
         public User(string name, string email, string phonenumber, string address, int age, string gender)
        {
            this.name = name;
            this.email = email;
            this.phonenumber = phonenumber;
            this.address = address;
            this.age = age;
            this.gender = gender;
            
        }
    }
}
public class Reader : User
{
     private string id;
     private List<Book> books;

    public Reader(string name, string email, string phonenumber, string address, string id   , int age ,string gender) : base(name, email, phonenumber, address,age,gender)
    {
         this.id = id;
         this.books = new List<Book>();

    }
    public class Librarian : User
    {
        private string Librarian_id;
        public Librarian(string name, string email, string phonenumber, string address, int age,string gender ,string Librarian_id)
        : base(name, email, phonenumber, address, age, gender)

        {
            this.Librarian_id = Librarian_id;


        }

    }
}





