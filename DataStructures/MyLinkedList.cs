using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class MyLinkedList
    {
        public MyLinkedList()
        {

        }
        public class Node
        {
            public Node Next;
            public object Data;
        }

        //Count items in the list
        private int size;
        public object Count
        {
            get
            {
                return "There are " + size + " items in your list.";
            }
        }
        //head of list
        private Node head;

        //current Node
        private Node currentNode;

        private Node PreviousNode;
        public void AddFirst(object item)
        {

            if (head == null)
            {
                currentNode = PreviousNode = new Node() { Data = item };
            }
            else
            {
                PreviousNode = PreviousNode.Next = new Node() { Data = item };
            }
            size++;
        }

        //Add a new Node to my list
        public void Add(object item)
        {
            size++;
            var node = new Node()
            {
                Data = item
            };
            if (head == null)
            {
                head = node;
            }
            else
            {
                currentNode.Next = node;
            }
            // Makes newly added node the current node
            currentNode = node;
        }

<<<<<<< HEAD
        public void AddLast(object item)
        {
            Node newNode = new Node();
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                currentNode = head;
                while (currentNode != null)
                {
                    PreviousNode = currentNode;
                    currentNode = currentNode.Next;
                }
                PreviousNode.Next = newNode;
            }
            newNode.Next = null;
            size++;
        }

        //Delete Method
=======
        //Delete Method at an index
>>>>>>> e19425eef7993d720351cae71275242d54f0ac4d
        public bool Delete(int index)
        {
            if (index == 1)
            {
                head = null;
                PreviousNode = null;
                return true;
            }
            if (index > 1 && index < size)
            {
                Node tempNode = head;
                Node lastNode = null;
                int count = 0;
                while (tempNode != null)
                {
                    if (count == (index - 1))
                    {
                        lastNode.Next = tempNode.Next;
                    }
                    count++;
                    lastNode = tempNode;
                    tempNode = tempNode.Next;
                }
            }
            size--;
            return false;
        }

        //Print my List
        public void ListNodes()
        {
            Node tempNode = head;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.Data);
                tempNode = tempNode.Next;
            }
        }



    }
}
