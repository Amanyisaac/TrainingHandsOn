using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore
{
    public class Reader : User
    {
        public List<Book> Books { get; private set; }

        public Reader(string name, string email, string phoneNumber, string address, int age, string gender, string id)
            : base(name, email, phoneNumber, address, age, gender, id)
        {
           this.Books = new List<Book>();

        }

    }
}

