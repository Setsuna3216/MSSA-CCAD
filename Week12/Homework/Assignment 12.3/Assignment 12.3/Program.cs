using System.Text;

namespace Assignment_12._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Remove All Adjacent Duplicates In String ===");
            string[] tests = { "abbaca", "azxxzy", "aa", "abc" };
            foreach (var s in tests)
                Console.WriteLine($"\"{s}\" -> \"{RemoveDuplicates(s)}\"");
        }

        static string RemoveDuplicates(string s)
        {
            var stack = new StringBuilder();
            foreach (char c in s)
            {
                if (stack.Length > 0 && stack[stack.Length - 1] == c)
                    stack.Length--;
                else
                    stack.Append(c);
            }
            return stack.ToString();
        }
    }
}