namespace Assignment_1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the sum of [input] natural numbers.");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            Console.WriteLine($"The first {n} natural number is :");

            for (int i = 1; i <= n; i++)
            { 
                Console.WriteLine(i);
                sum = sum + i;
            }


            Console.WriteLine($"The Sum is : {sum}");
        }
    }
}
