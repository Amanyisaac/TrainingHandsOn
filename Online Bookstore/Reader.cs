using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore
{
    public class Reader : User
    {
        private List<Book> books;

        public Reader(string name, string email, string phonenumber, string address, int age, string gender, string id) : base(name, email, phonenumber, address, age, gender, id)
        {
            this.books = new List<Book>();

        }

    }
}

