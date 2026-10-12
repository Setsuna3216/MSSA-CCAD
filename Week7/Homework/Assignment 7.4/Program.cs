namespace Assignment_7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem parking = new ParkingSystem(1, 1, 0);

            Console.WriteLine("Test 1 - Big Car");
            Console.WriteLine(parking.addCar(1)); // True

            Console.WriteLine("Test 2 - Medium Car");
            Console.WriteLine(parking.addCar(2)); // True

            Console.WriteLine("Test 3 - Small Car");
            Console.WriteLine(parking.addCar(3)); // False

            Console.WriteLine("Test 4 - Big Car Again");
            Console.WriteLine(parking.addCar(1)); // False
        }
    }
}
