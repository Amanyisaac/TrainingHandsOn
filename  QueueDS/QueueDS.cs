using DataStrutures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
public class QueueDS
{
    public Node Front { get; set; } 
    public Node Rear { get; set; } 
    public QueueDS()
	{
        Front = null; // head 
        Rear = null; // end
	}
    public bool isEmpty()
    {
        if (Front == null && Rear == null)
        {
            return true;
        }
        else
        {
            return false;
        }


        public void enqueue(int value)
        {
            Node newnode = new Node(value);
            if (isEmpty())
            { //  is empty
                Front = Rear = newnode;// if the queue is empty set both front and rear to the new node

            }
            else
            { // not empty

                Rear.next = newnode;// refer the next of the rear to the new node
                Rear = newnode;// refer the rear to the new node
            }

        }





public int dequeue()
    {
        if (isEmpty())
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }
        else
        {
            int delvalue = Front.data; // store the data of the front node to return it later
                Front = Front.next; // move the front to the next node
                return delvalue; // return the data of the front node
            }
    }



      

        public int getFront() // return the data of the head 
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1; // return -1 if the queue is empty
            }
            else
            {

                return Front.data; // return the data of the front node
            }
        }
    }



    public int getRear()
    {
        if (isEmpty())
        {
            Console.writeLine("Queue is empty");
            return -1; // return -1 if the queue is empty
        }
        else
        {
            return Rear.data; // return the data of the rear node
        }
    }



    public int count()
    {
        if (isEmpty())
        {
            Console.WriteLine("Queue is empty ");
            return 0;
        }

        else
        {

            int count = 0; // initialize a counter variable
            Node temp = Front; // start from the front of the queue
            while (temp != null)
            {
                count++; // increment the counter for each node
                temp = temp.next; // move to the next node 
            }
            return count; 
        }
    }

  
        public void clear() // clear all elemnts
        {
            while (!isEmpty())  
            {
                dequeue();  
            }
        }

    }
              


            public void display()
                {

                    if (isEmpty())
                    {
                        Console.WriteLine("Queue is empty, nothing to display.");
                    }
                    else {
                        Node temp = Front; // start from the front of the queue 
                        while (temp != null)
                        {
                            Consol.Write(temp.data + " "); // print the data of the node
                            temp = temp.next; // move to the next node
                        }
                        Console.WriteLine();
                    }

                 }
