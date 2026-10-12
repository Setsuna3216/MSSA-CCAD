using System.Text;

namespace Mod1StringsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string is a sequence of characters enclosed in double quotes.
            // char array
            // immutable
            //avoid too many concatenations
            //1.
           string s = "deepali";
            s = s + " kamatkar";

            //2.
            StringBuilder sb = new StringBuilder("deepali");
            sb.Append(" kamatkar");

            string s1 = "   precious ";

            Console.WriteLine($"Length of string :{s1.Length}");
            Console.WriteLine(s1.Trim());
            s1 = s1.Trim();
            Console.WriteLine(s1);
            Console.WriteLine($"Length of string after trimming:{s1.Trim().Length}");


            string s2 = "* A Short Story, *";
            var header = s2.Trim(new char[] { '*', ',' });
            Console.WriteLine($"Header value after trim:{header}");
           

            var chars = s2.ToCharArray();
            foreach(char c in chars)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("each char from string:");
            foreach(char c in header)
            {
                Console.WriteLine(c);
            }

            string names = "aa,bb,cc,dd";
            var words = names.Split(new char[] { ',', ' ' });
            foreach(var word in words)
            {
                Console.WriteLine(word);
            }

            string s3 = "wake up early in the morning";
            Console.WriteLine(s3.Replace("wake up", "exercise"));
            //
            //"aabcbbabba"

            Console.WriteLine(s3.Substring(4));
            Console.WriteLine(s3.Substring(4, 5));

        }
    }
}
