namespace Assignment_1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("Choose your shape to find area");
                Console.WriteLine("1. triangle");
                Console.WriteLine("2. square");
                Console.WriteLine("3. rectangle");
                Console.WriteLine("4. end");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1) 
                {
                    Console.WriteLine("What is the length:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the height:");
                    int b = int.Parse(Console.ReadLine());
                    double result = triangle(a, b);
                    Console.WriteLine($"Area is equal to {result}");
                }
                if (choice == 2)
                {
                    Console.WriteLine("What is the length:");
                    int a = int.Parse(Console.ReadLine());
                    double result = square(a);
                    Console.WriteLine($"Area is equal to {result}");
                }
                if (choice == 3)
                {
                    Console.WriteLine("What is the length:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the height:");
                    int b = int.Parse(Console.ReadLine());
                    double result = rectangle(a, b);
                    Console.WriteLine($"Area is equal to {result}");
                }
                else 
                {
                    Console.WriteLine("program end"); 
                }
            }
        }
        static double triangle(int a, int b)
        {
            return 0.5 * a * b;
        }
        static double square(int a)
        {
            return a * a;
        }

        static double rectangle(int a, int b)
        {
            return a * b;
        }
    }
}
