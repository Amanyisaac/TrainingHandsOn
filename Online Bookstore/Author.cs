
using MyBookStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net;
 
namespace MyBookStore
{
    public class Author
    {
        private string name;

        public Author(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public void display_info()
        {
            Console.WriteLine("Author Name: " + name);
        }
    }
}
