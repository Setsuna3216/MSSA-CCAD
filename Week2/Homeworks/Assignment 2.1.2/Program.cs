namespace Assignment_2._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Caculator c = new Caculator();
            //Test
            //Console.WriteLine($"Result:{Calculator.Add(1,2)}");
            //Console.WriteLine($"Result:{Calculator.Add(1.2m,2.3m,3.1m)}");
            //Console.WriteLine($"Result:{Calculator.Multiply(1.2f, 2.3f)}");
            //Console.WriteLine($"Result:{Calculator.Multiply(1.2f, 2.3f, 3.1f)}");

            Console.WriteLine("Choose a calculation");
            Console.WriteLine("1. Add 2 integers");
            Console.WriteLine("2. Add 3 decimals");
            Console.WriteLine("3. Multiply 2 floats");
            Console.WriteLine("4. Multiply 3 floats");
            int choice = int.Parse(Console.ReadLine());
            int n1, n2;
            decimal m1, m2, m3;
            float f1, f2, f3;
        

            if( choice == 1)
            {
                Console.WriteLine("Enter first integer");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second integer");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Result:{Calculator.Add(n1, n2)}");
            }
            else if(choice == 2)
            {
                Console.WriteLine("Enter first decimal");
                m1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter second decimal");
                m2 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter third decimal");
                m3 = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"Result:{Calculator.Add(m1, m2, m3)}");

            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter first float");
                f1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter second float");
                f2 = float.Parse(Console.ReadLine());
                Console.WriteLine($"Result:{Calculator.Multiply(f1, f2)}");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter first float");
                f1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter second float");
                f2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter third float");
                f3 = float.Parse(Console.ReadLine());
                Console.WriteLine($"Result:{Calculator.Multiply(f1, f2, f3)}");
            }
            else
            {
                Console.WriteLine("No such option");
            }

        }
    }
}
