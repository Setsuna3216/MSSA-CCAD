namespace Assignment_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1 - Length of Last Word
            Console.WriteLine("Q1:");
            Console.WriteLine(LastWordLength("Hello World"));           // Expected: 5
            Console.WriteLine(LastWordLength("   fly me   to   moon ")); // Expected: 4


            // Q2 - Print first N natural numbers
            Console.WriteLine("\nQ2:");
            PrintFirstNNaturalNumber(10);                               // Expected: 1 2 3 4 5 6 7 8 9 10
            Console.WriteLine();


            // Q3 - Print N to 1
            Console.WriteLine("\nQ3:");
            PrintnumbersFromNto1(10);                                  // Expected: 10 9 8 7 6 5 4 3 2 1
            Console.WriteLine();


            // Q4 - Palindrome using recursion
            Console.WriteLine("\nQ4:");
            Console.WriteLine(IsStringPalindrome("RADAR", 0));          // Expected: True
            Console.WriteLine(IsStringPalindrome("LEVEL", 0));          // Expected: True
            Console.WriteLine(IsStringPalindrome("HELLO", 0));          // Expected: False
        }
        static int LastWordLength(string s)
        {
            int i = s.Length - 1;
            int count = 0;
            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }
            while (i >= 0 && s[i] != ' ')
            {
                i--;
                count = count + 1;
                
            }
            return count;

        }

        static void PrintFirstNNaturalNumber(int n)
        {
            
            if (n == 0)
            {
                return;
            }
            
            PrintFirstNNaturalNumber(n-1);
            Console.Write(n + " ");
        }

        static void PrintnumbersFromNto1(int n)
        {

            if (n == 0)
            {
                return;
            }
            Console.Write(n + " ");
            PrintnumbersFromNto1(n - 1);
            
        }

        static bool IsStringPalindrome(string s, int n)
        {
            if (n == s.Length / 2)
            {
                return true;
            }
            if (s[n] != s[s.Length - n - 1])
            {
                return false;
            }
            else
            {
                return IsStringPalindrome(s, n + 1);
            }

        }
    }
}
