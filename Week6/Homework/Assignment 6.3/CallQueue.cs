using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6._3
{
    internal class CallQueue
    {
        Caller front;
        Caller rear;
        int size;
        public void Enqueue(Caller newCaller)
        {
            if (front == null)
            {
                front = newCaller;
                rear = newCaller;
                
            }
            else
            {
                rear.next = newCaller;
                rear = newCaller;
                
            }
            size++;

        }
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Caller Queue is Empty");
                return;
            }
            else
            {
                front = front.next;
                if (front == null)
                {
                    rear = null;
                }
                size--;
            }

        }
        public void Display()
        {
            Caller current = front;

            while (current != null)
            {
                Console.WriteLine($"Caller Name: {current.name}");

                current = current.next;
            }
            Console.WriteLine($"CallQueue Size: {size}");
        }
    }
}
