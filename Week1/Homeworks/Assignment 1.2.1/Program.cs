namespace Assignment1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check 2 numbers are equal or not.");
            Console.WriteLine("Input 1st number:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            int n2 = int.Parse(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine($"{n1} and {n2} are equal");
            }
            else
            {
                Console.WriteLine($"{n1} and {n2} are not equal");
            }  
                
        }
    }
}
