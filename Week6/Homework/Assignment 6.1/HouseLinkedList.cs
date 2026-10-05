using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6._1
{
    internal class HouseLinkedList
    {
        public House head;
        public void Search(int number)
        {
            House current = head;
            while (current != null && current.houseNumber != number)
            {
                current = current.next;
            }
            if (current == null)
            {
                Console.WriteLine("House not found");
            }
            else
            {
                Console.WriteLine($"House Number: {current.houseNumber}");
                Console.WriteLine($"House Address: {current.briefAddress}");
                Console.WriteLine($"House Type: {current.typeOfHouse}");
            }
        }
        public void Display()
        {
            House current = head;
            while (current!= null)
            {
                Console.WriteLine($"House Number: {current.houseNumber}");
                Console.WriteLine($"House Address: {current.briefAddress}");
                Console.WriteLine($"House Type: {current.typeOfHouse}");
                current = current.next;
            }
            
        }
        public void Add(House newHouse)
        {
            if (head == null)
            {
                head = newHouse;
            }
            else
            {
                House current = head;
                while (current.next != null) 
                {
                    current = current.next;
                }
                current.next = newHouse;
            }
        }

    }

    
}
