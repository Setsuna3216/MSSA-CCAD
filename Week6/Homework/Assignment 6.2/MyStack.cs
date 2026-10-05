using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6._2
{
    internal class MyStack
    {
        int[] stack;
        int top;
        public MyStack(int size)
        {
            stack = new int[size];
            top = -1;
        }

        public void Push(int value)
        {
            if(top == stack.Length - 1)
            {
                Console.WriteLine("Stack is full.");
                return;
            }
            else
            {
                top++;
                stack[top] = value;
            }
        }
        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }
            else
            {
                int popValue = stack[top];
                top--;
                Console.WriteLine(popValue);

            }
        }

    }

}
