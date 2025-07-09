using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrutures.QueueDS
{
    public class queueDS
    {
        Node front;
        Node rear;

        queueDS(Node front, Node rear)
        {
            this.front = front;
            this.rear = rear;
        }
        public queueDS()
        {
            front = null;
            rear = null;
        }
        public bool isEmpty()
        {


            return front == null;
        }

        public void enqueue(int item)
        {
            Node newnode = new Node(item);
            if (isEmpty())
            {
                front = newnode;
                rear = newnode;
            }
            else
            {
                rear.next = newnode;
                rear = newnode;
            }
        }
        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node current = front;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }


        public int Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
                throw new InvalidOperationException("Queue is empty");
            }
            else if (front == rear)
            {
                int item = front.data;
                front = null;
                rear = null;
                return item;
            }
            else
            {
                Node temp = front;
                front = front.next;
                int item = temp.data;
                temp = null;
                return item;
            }
        }
        public int getFront()
        {
            return front.data;
        }
        public int getRear()
        {
            return rear.data;
        }
        public int count()
        {
            int count = 0;
            Node current = front;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }

        public int found(int item)
        {
            Node current = front;
            int index = 0;
            while (current != null)
            {
                if (current.data == item)
                {
                    return index;
                }
                current = current.next;
                index++;
            }
            return -1;
        }
        public void clear()
        {
            while (!isEmpty())
            {
                Dequeue(); //oop step!
            }
        }
    }
}
