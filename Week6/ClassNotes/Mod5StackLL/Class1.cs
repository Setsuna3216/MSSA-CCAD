using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5StackLL
{
    internal class Node
    {
        public int Data { get; set; }
        public Node next;
        public Node(int value)
        {
            this.Data = value;
            this.next = null;
        }
    }
    class StackLL
    {
        Node top;//head of the ll
        int size;
        public StackLL()
        {
            this.top = null;
            this.size = 0;
        }
        public bool IsEmpty()
        {
            return this.size == 0;
        }
        //Addfirst
        public void Push(int val)
        {
            Node newNode = new Node(val);
            if(IsEmpty())
            {
                this.top = newNode;
            }
            else
            {
                newNode.next = this.top;
                this.top = newNode;
            }
            size++;
        }
        public int Pop()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            int val = top.Data;
            top = top.next;
            size--;
            return val;
        }
        public int Peek()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            return top.Data;
        }
        public void Display()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return;
            }
            Node temp = top;
            while(temp!=null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.next;
            }

        }

    }

}
