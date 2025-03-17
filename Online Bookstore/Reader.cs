using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore
{
    public class Reader
    {
        private String name;
        private int age;
        private string id;
        private string phonenumber;
        private String email;
        private String gender;
        private String address;
        private Vector<Book> booksList;

        public Reader(string name, int age, string id, string phonenumber, string email, string gender, string address)
        {
            
            this.name = name;
            this.age = age;
            this.id = id;
            this.phonenumber = phonenumber;
            this.email = email;
            this.gender = gender;
            this.address = address;
            this.booksList = new Vector<Book>();
        }
        }
    }
