using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Stack
    {

        Node tos;

        public void createStack()
        {
            tos = null;//root is not created but assigned
        }

        public void push(int data)
        {
            Node n = new Node(data);//created node
            if (tos == null)//not created
            {
                tos = n;//1st one assigned as root
            }
            else
            {
                n.next = tos;//1
                tos = n;//2
            }
            Console.WriteLine("Pushed");
        }
        public void pop()   
        { 
            if (tos == null)//not created
            {
                Console.WriteLine("Stack is Empty:");
            }
            else
            {
                Node t = tos;//1
                tos = tos.next;//2
                Console.WriteLine(t.data + " poped");
            }
        }
        public void peek()
        {
            if (tos == null)//not created
            {
                Console.WriteLine("Stack is Empty:");
            }
            else
            {
                Console.WriteLine(tos.data + " @ Peek");
            }
        }
        public void printStack()
        {
            if (tos == null)//not created
            {
                Console.WriteLine("Empty Stack:");
            }
            else
            {
                Node t = tos;//1
                while (t != null)//2
                {
                    Console.WriteLine(t.data);
                    t = t.next;
                }
            }
        }
    }
}
