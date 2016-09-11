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
            myList.Add("A");
            myList.Add(20);
            myList.Add("Time to go");
            myList.Add("H");
            myList.ListNodes();
            Console.WriteLine("Now time to delete @ position 2");
            myList.Delete(2);
            myList.ListNodes();
            Console.WriteLine(myList.Count);

            Node first = new Node{Data = 3};
            Node Second = new Node{Data = 5};

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
