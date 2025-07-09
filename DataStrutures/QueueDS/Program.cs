using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrutures.QueueDS
{
    public class Program
    {
        static void main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                queueDS queue = new queueDS();
                queue.enqueue(i);
                Console.WriteLine("Queue after enqueueing " + i + ":");
                queue.display();
            }
            queueDS queue2 = new queueDS();
            queue2.enqueue(1);
            queue2.enqueue(2);


            Console.WriteLine("Queue2 after enqueueing 1 and 2:");
            queue2.display();

            Console.WriteLine("Clear all items");
            queue2 = new queueDS();
            Console.WriteLine("Display after clear");
            queue2.display();


        }
    }
}