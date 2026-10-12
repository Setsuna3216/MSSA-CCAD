using Helpers;

namespace Mod6StructDemo
{
    internal class Program
    {
        // mvc, mvvm
        static void Main(string[] args)
        {
            PostalAddress myaddress = new PostalAddress();//default constructor call

            Console.WriteLine($"hashcode {myaddress.GetHashCode()} , type: {myaddress.GetType()}");
            Console.WriteLine("Enter the postal address..");
            Console.WriteLine("Enter the house number if any");
            myaddress.HouseNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the street name if any");
            myaddress.StreetName = Console.ReadLine();
            Console.WriteLine("Enter the city ");
            myaddress.City = Console.ReadLine();
            Console.WriteLine("Enter the zipcode ");
            myaddress.ZipCode = Int32.Parse(Console.ReadLine());

           Console.WriteLine(myaddress.PrintAddress());



            PostalAddress officeAddress = new PostalAddress(34, "Prospect Ave", "NY", 6668);
            officeAddress.StreetName = "Prospect St";
            Console.WriteLine(officeAddress.PrintAddress());

        }
    }
}
