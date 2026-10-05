namespace Assignment_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Square square = new Square();
            Console.WriteLine(" select a shap to find its area");
            Console.WriteLine("1.circle");
            Console.WriteLine("2.square");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) 
            {
                Console.WriteLine("What is its radius:");
                double radius = double.Parse(Console.ReadLine());
                circle.r = radius;
                Console.WriteLine($"The area of the circle is {circle.CalculateArea()}");
            }
            else if (choice == 2)
            {
                Console.WriteLine("What is its length:");
                double length = double.Parse(Console.ReadLine());
                square.l= length;
                Console.WriteLine($"The area of the square is {square.CalculateArea()}");
            }
        }
    }
}
