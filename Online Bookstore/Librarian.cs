using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Bookstore
{

    public class Librarian : User
    {
        public Librarian(string name, string email, string phoneNumber, string address, int age, string gender, string id)
            : base(name, email, phoneNumber, address, age, gender, id) { }
 

        }

    }


