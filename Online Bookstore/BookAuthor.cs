using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore
{


    public class BookAuthor
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public List<Book> Books { get; private set; }


        public BookAuthor(String name, String email)
        {
            this.Name = name;
            this.Email = email;
            this.Books = new List<Book>();
        }
    }
}

