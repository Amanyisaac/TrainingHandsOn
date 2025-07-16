using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrutures
{
    public class Program

    class Program
    {
        static void Main(string[] args)
        {
            QueueDS queue = new QueueDS();
            queue.enqueue(10);
            queue.enqueue(20);
            queue.enqueue(30);

            Console.WriteLine("Front item: " + queue.getFront()); 
            Console.WriteLine("Rear item: " + queue.getRear());
 
            Console.WriteLine("Dequeue item: " + queue.dequeue());
 
            Console.WriteLine("Is queue empty? " + queue.isEmpty()); 

            queue.display();

            // Clear the queue
            queue.clear();
            Console.WriteLine("Queue cleared.");
            Console.WriteLine("Is queue empty? " + queue.isEmpty());

        }

    }
    }



















