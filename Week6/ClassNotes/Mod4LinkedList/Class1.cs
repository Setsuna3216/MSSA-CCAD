using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4LinkedList
{
    class HouseNode
    {
        //data
        public int HouseNumber { get; set; }
        public string HouseAddress { get; set; }
        public string HouseType { get; set; }

        public HouseNode next;
    }
    internal class Node
    {
        public int Data { get; set; }// diff data type possible
        public Node next;//pointer/reference to next node, link

        public Node(int val)
        {
            Data = val;
            next = null;
        }
    }

    class Linkedlist
    {
        private Node head;
        private Node tail;
        private int size;
        public int Size { get { return size; } }// giving us the count of nodes

        public Linkedlist()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public bool IsEmpty()
        {
            return size == 0;
        }
        //O(1)
        public void AddFirst(int val)
        {
            Node newNode = new Node(val);//create a new node
            if(IsEmpty())
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.next = this.head;// put the newest node before the existing head
                head = newNode;// update the head to point to the newest node;
            }
            size++;
        }

        //O(n)
        public void Display()
        {
            Node temp = head;
            if(IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return;
            }
            else
            {
                while(temp!=null)
                {
                    Console.Write(temp.Data + " ");
                    temp = temp.next;
                }
            }
        }

        //o(1)
        public void AddLast(int val)
        {
            Node newNode = new Node(val);
            if(IsEmpty())
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            size++;
        }

        //o(1)
        public int RemoveFirst()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Linked list is empty!");
            }
            int val = head.Data;//store the value that needs to be removed.
            head = head.next;
            size--;

            if(IsEmpty())//only 1 node was in the list and that was removed, so now there are 0 nodes
            {
                tail = null;
            }
            return val;
        }

        //o(n)
        public int RemoveLast()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("List is empty!");
            }
            Node temp = head;
            int i = 1;
            while(i<size-1)// move temp to point to second last node;
            {
                temp = temp.next;
                i++;
            }
            //temp is pointing to second last node;
            int val = tail.Data;
            tail = temp;//update tail to point to second last
            tail.next = null;
            size--;
            if(IsEmpty())// there was only 1 node and that was removed
            {
                head = null;
            }
            return val;
        }
        //o(n)
        public void AddAnyWhere(int val, int position)
        {
            if(position<=0 || position>size+1)
            {
                throw new InvalidOperationException("Invalid Position");
            }
            if(position ==1)
            {
                AddFirst(val);
                return;
            }
            if(position==size+1)
            {
                AddLast(val);
                return;
            }
            Node newNode = new Node(val);
            Node temp = head;
            int i = 1;
            while(i<position-1)
            {
                temp = temp.next;
                i++;
            
            }
            //temp is pointing to a node before the position
            newNode.next = temp.next;
            temp.next = newNode;

            size++;
        }
   
        //o(n)
        public int RemoveAnywhere(int position)
        {
            if(position<=0 || position>size)
            {
                throw new InvalidOperationException("Invalid Position");
                
            }
            if(position==1)
            {
                return RemoveFirst();
            }
            if(position==size)
            {
                return RemoveLast();
            }

            Node temp = head;
            int i = 1;
            while(i<position-1)
            {
                temp = temp.next;
                i++;
            }
            int val = temp.next.Data;
            temp.next = temp.next.next;
            size--;

            return val;

        }

        public bool Search(int val)
        {
            Node temp = head;
            while(temp!=null)
            {
                if(temp.Data==val)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        
    }

}
