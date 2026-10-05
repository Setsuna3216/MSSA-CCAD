namespace Assignment_2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter bill total:");
            double bill = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter tip %:");
            double tipPercentage = double.Parse(Console.ReadLine());

            double grandTotal = bill * (1 + tipPercentage/100);
            double tipPaid = bill * (tipPercentage / 100);

            Console.WriteLine($"Bill: {bill:C}");
            Console.WriteLine($"Tip Percentage: {tipPercentage}%");
            Console.WriteLine($"Tip: {tipPaid:C}");
            Console.WriteLine($"Grand total: {grandTotal:C}");
        }
    }
}
