namespace Mod2Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variable demo");
            //data type variablename;
            const float rateOfInterest=3.4f;


            
            int i;//declaration , defaults to 0
            i = 20;
            int num1, num2;
            Console.WriteLine("Enter 2 numbers..");
            Console.WriteLine("Enter number1:");
            num1 =Int32.Parse(Console.ReadLine());
            //"34"
            Console.WriteLine("Enter number2");
            num2 = Int32.Parse(Console.ReadLine());
            int sum = num1 + num2;//-, * ,/, %
            Console.WriteLine($"the sum of {num1} and {num2} is {sum} ");
            
            string name, address;
            int age;

            name = Console.ReadLine();
        }
    }
}
