using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Queue
    {
        Node front, rear;

        public void createQueue()
        {

            front = rear = null;//root is not created but assigned
        }

        public void dequeue()
        {
            if (front == null)//not created
            {
                Console.WriteLine("Queue is Empty:");
            }
            else
            {
                Node t = front;//1
                if (front == rear)//reseting front and rear for next round
                {
                    front = rear = null;
                }
                else
                {
                    front = front.next;//2
                }
                Console.WriteLine(t.data + " dequeued");
            }
        }
        public void enqueue(int data)
        {
            Node n = new Node(data);//created node
            if (rear == null)//not created
            {
                front = rear = n;//1st one assigned as root
            }
            else
            {
                rear.next = n;
                rear = n;
            }
            Console.WriteLine("Inserted");
        }
        public void printQueue()
        {
            if (front == null)//not created
            {
                Console.WriteLine("Empty queue:");
            }
            else
            {
                Node t = front;//1
                while (t != null)//2
                {
                    Console.WriteLine("|" + t.data + "|---");
                    t = t.next;
                }
            }
        }
    }
}
