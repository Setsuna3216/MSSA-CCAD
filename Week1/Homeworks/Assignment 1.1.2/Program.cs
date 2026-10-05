namespace Assignment_1._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter 2 numbers to get the sum");
            Console.WriteLine("Enter number1:");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2:");
            num2 = Int32.Parse(Console.ReadLine());

            int sum = num1 + num2;//-, * ,/,%
            Console.WriteLine($"the sum of {num1} and {num2} is {sum}");
        }
    }
}
