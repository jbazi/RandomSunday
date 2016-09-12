using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
        
        public Node() 
        { 
            Data = 0; 
            Next = null; 
        }

        public Node(int d, Node n)
        {
            Data = d;
            Next = n;
        }
    }

    class LinkedListNode<T>
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList myList = new MyLinkedList();
            MyStack myStack = new MyStack();
            Console.WriteLine("________Start Of Stack class_______");
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.Push("numbers");
            myStack.Display();
            Console.WriteLine("Removing an item from my stack - LIFO");
            myStack.Pop();
            Console.WriteLine("After the pop");
            myStack.Display();
            Console.WriteLine("There are "+ myStack.getSize + " items in your stack"); 
            Console.WriteLine("________End Of Stack class_______\n");
            Console.WriteLine("Returning the last item");
            Console.WriteLine(myStack.Peek());

            Console.WriteLine("________Start Of Linked List class_______");
            myList.Add("A");
            myList.Add(20);
            myList.Add("Time to go");
            myList.Add("H");
            Console.WriteLine(myList.Count);
            myList.ListNodes();
            Console.WriteLine("Now time to delete @ position 2");
            myList.Delete(2);
            myList.ListNodes();
            Console.WriteLine(myList.Count);
            Node first = new Node{Data = 3};
            Node Second = new Node{Data = 5};
            Console.WriteLine("_________Adding item at the end of the list_________");
            myList.AddLast("Z");
            Console.WriteLine(myList.Count);
            myList.ListNodes();
            Console.WriteLine("_________Adding item at the beginning of the list_________");
            myList.AddFirst(100);
            myList.ListNodes();

            //point first to second node
            first.Next = Second;
            Second.Previous = first;
            Node Third = new Node { Data = 7 };
            Second.Next = Third;
            Third.Previous = Second;
            Node lastItem = new Node { Data = 10 };
            AddLast(lastItem,20);
            Console.WriteLine("____________Printing Next items_________");
            PrintList(first);
            Console.WriteLine("____________Printing previous items_________");
            PrintPreviousItems(Third);
            
            Console.WriteLine("End Of Linked List class_______");
            Console.ReadKey();
        }

        public static void AddLast(Node newNode, int newData)
        {
            while (newNode.Next != null)
                newNode = newNode.Next;
            newNode.Next = new Node(newData, null);
        }

        public static void PrintList(Node node) 
        {
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }

        public static void PrintPreviousItems(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Previous;
            }
        }
    }
}
