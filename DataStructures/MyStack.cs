using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class MyStack : StackInterface
    {
        public int Size { get; set; }

        public int getSize
        {
            get
            {
                return Size;
            }
            set
            {
                Size = value;
            }
        }
        public int top;
        Object[] item;

        public MyStack()
        {
            Size = 10;
            item = new Object[Size];
            top = -1;
        }

        public MyStack(int capacity)
        {
            Size = capacity;
            item = new Object[Size];
            top = -1;
        }

        public bool isEmpty()
        {
            if (top == -1) 
                return true;
            return false;
        }

        public void Push(object element)
        {
            if (top == (Size - 1))
            {
                Console.WriteLine("Stack is full!");
            }

            else
            {

                item[++top] = element;
            }
        }

        public object Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {

                return item[top--];
            }
        }

        public object Peek()
        {
            if (isEmpty())
            {

                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return item[top];
            }
        }

        public void Display()
        {
            for (int i = top; i > -1; i--)
            {

                Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
            }
        }
    }
}
