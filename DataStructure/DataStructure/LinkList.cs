using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class LinkList
    {
        internal Node head;

        public void InsertFront(int data)
        {
            Node newNode = new Node(data);   
            newNode.next = head;
            head = newNode;
        }

        public void InsertBack(int data)
        {
            Node newNode2 = new Node(data);
            if (head == null)
            {
                head = newNode2;
            }
        }

        public void InsertAfter(Node prevNode, int data)
        {
            if(prevNode == null)
            {
                Console.WriteLine("the given data is not available in list");
                return;
            }
            Node newNode3 = new Node(data);
            newNode3.next = prevNode.next;
            prevNode.next = newNode3;
        }

        internal Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
               temp = temp.next;
            }
            return temp;
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
        }
    }
}
