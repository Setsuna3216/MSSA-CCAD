namespace Assignment_1._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, address;
            int age;
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your address:");
            address = Console.ReadLine();

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }
    }
}
