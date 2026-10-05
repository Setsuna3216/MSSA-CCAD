using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5StackArrayDEmo
{
    internal class StackArray
    {
        private int[] data;
        private int top;
        public StackArray(int size)
        {
            data = new int[size];
            top = -1;

        }
        public bool IsEmpty()
        {
            return top == -1;
        }
        public bool IsFull()
        {
            return top == data.Length - 1;
        }
        //o(1)
        public void Push(int value)
        {
            if(IsFull())
            {
                throw new InvalidOperationException("Stack is full!");
            }
            top++; //top will change to 0top=top+1
            data[top] = value;
           // data[++top] = value;
        }

        //o(1)
        public int Pop()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            int value = data[top];
            top--;
            return value;
        }
        public int Peek()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");

            }
            return data[top];
        }
        //o(n)
        public void Display()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            for(int i=top;i>=0;i--)
            {
                Console.WriteLine(data[i]);
            }

        }


    }
}
