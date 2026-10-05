namespace Assignment_1._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter 2 numbers to get the quotient and remainder");
            Console.WriteLine("Enter number1:");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2:");
            num2 = Int32.Parse(Console.ReadLine());

            int quotient = num1 / num2;//-, * ,/,%
            int remainder = num1 % num2;

            Console.WriteLine($"the quotient of {num1} and {num2} is {quotient}");
            Console.WriteLine($"the remainder of {num1} and {num2} is {remainder}");
        }
    }
}
