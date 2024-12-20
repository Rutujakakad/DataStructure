// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using DataStructure;

class Program
{
    static void Main(string[] args)
    {
        //==========================LinkList
        //LinkList list = new LinkList();

        //list.InsertFront(10);
        //list.InsertFront(20);
        //list.InsertBack(30);
        //list.InsertBack(25);
        
        //Node newNode3= list.GetLastNode();
        //list.InsertAfter(newNode3, 40);
        //list.InsertBack(50);
        //Console.WriteLine("Link List :");
        //list.Display();

        ////=========================Stack
        //Stack st = new Stack();
        //st.createStack();
        //int choice;
        //do
        //{
        //    Console.WriteLine("\n1.Push\n2.Pop\n3.Peek\n4.Print:\n0.Exit :");
        //    choice =int.Parse(Console.ReadLine());
        //    switch (choice)
        //    {
        //        case 1:
        //            Console.WriteLine("Enter Data:");
        //            int ele = int.Parse(Console.ReadLine());
        //            st.push(ele);
        //            break;
        //        case 2:
        //            st.pop();
        //            break;
        //        case 3:
        //            st.peek();
        //            break;
        //        case 4:
        //            st.printStack();
        //            break;
        //        case 0:
        //            Console.WriteLine("Exiting thank for using code");
        //            break;
        //        default:
        //            Console.WriteLine("Wrong option selected");
        //            break;

        //    }

        //} while (choice != 0);
        
        //=========================================Queue
        Queue que = new Queue();
      //  int element = int.Parse(Console.ReadLine());
        int ch;
        que.createQueue();//creating stack
        do
        {
            Console.WriteLine("\n1.Enqueue\n2.Dequeue\n3.Print:\n0.Exit :");
            ch =int.Parse(Console.ReadLine()) ;
         
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter element:");
                    int element = int.Parse(Console.ReadLine()) ;
                    que.enqueue(element);
                    break;

                case 2:
                    que.dequeue();
                    break;

                case 3:
                    que.printQueue();
                    break;

                case 0:
                    Console.WriteLine("Exiting thank for using code");
                    break;
                default:
                    Console.WriteLine("Wrong option selected");
                    break;

            }

        } while (ch != 0);

    }
}
