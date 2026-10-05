namespace Assignment_1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int result = 0;

            while (choice != 6) {
                Console.WriteLine("Chose a calculation function");

                Console.WriteLine("1.addition");
                Console.WriteLine("2.subtraction");
                Console.WriteLine("3.multiplication");
                Console.WriteLine("4.division");
                Console.WriteLine("5.continue");
                Console.WriteLine("6.exit");
                choice = int.Parse(Console.ReadLine());

                if (choice != 5)
                {
                   
                    if (choice == 1)
                    {   Console.WriteLine("Enter number1:");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number2:");
                        int n2 = int.Parse(Console.ReadLine());
                        result = n1 + n2;
                        Console.WriteLine($"{n1} + {n2} = {result}");
                        Console.WriteLine("Enter [5] to continue, [6] to exit");
                        choice = int.Parse(Console.ReadLine());
                    }
                    if (choice == 2)
                    {   Console.WriteLine("Enter number1:");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number2:");
                        int n2 = int.Parse(Console.ReadLine());
                        result = n1 - n2;
                        Console.WriteLine($"{n1} - {n2} = {result}");
                        Console.WriteLine("Enter [5] to continue, [6] to exit");
                        choice = int.Parse(Console.ReadLine());
                    }
                    if (choice == 3)
                    {   Console.WriteLine("Enter number1:");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number2:");
                        int n2 = int.Parse(Console.ReadLine());
                        result = n1 * n2;
                        Console.WriteLine($"{n1} x {n2} = {result}");
                        Console.WriteLine("Enter [5] to continue, [6] to exit");
                        choice = int.Parse(Console.ReadLine());
                    }
                    if (choice == 4)
                    {   Console.WriteLine("Enter number1:");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number2:");
                        int n2 = int.Parse(Console.ReadLine());
                        result = n1 / n2;
                        Console.WriteLine($"{n1} / {n2} = {result}");
                        Console.WriteLine("Enter [5] to continue, [6] to exit");
                        choice = int.Parse(Console.ReadLine());
                    }
                    
                }



            }

            Console.WriteLine("Program end.");
        }
    }
}
