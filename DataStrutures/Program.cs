
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataStrutures
{

    class Program
    {
        static void Main(string[] args)
        {
            LinkedListDS list = new LinkedListDS();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            Console.WriteLine("Linked List:");
            list.Traverse();

            Console.WriteLine("Adding node after 3:");
            list.AddAfter(3, 6);
            list.Traverse();

            Console.WriteLine("Adding node before 3:");
            list.AddBefore(3, 7);
            list.Traverse();

            Console.WriteLine("Removing node 3:");
            list.Remove(3);
            list.Traverse();
        }
    }
}
 

 