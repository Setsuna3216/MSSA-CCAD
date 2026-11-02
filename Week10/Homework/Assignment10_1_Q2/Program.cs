
using System;

namespace Assignment10_1_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuildParentheses("", 0, 0, 1);
        }

        static void BuildParentheses(
            string current,
            int open,
            int close,
            int n)
        {
            if (current.Length == n * 2)
            {
                Console.WriteLine(current);
                return;
            }

            // Try adding an opening parenthesis
            if (open < n)
            {
                BuildParentheses(
                    current + "(",
                    open + 1,
                    close,
                    n);
            }

            // Try adding a closing parenthesis
            if (close < open)
            {
                BuildParentheses(
                    current + ")",
                    open,
                    close + 1,
                    n);
            }
        }

    }
}
 