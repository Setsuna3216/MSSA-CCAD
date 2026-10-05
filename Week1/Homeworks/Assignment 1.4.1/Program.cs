namespace Assignment_1._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point();
            //Point y = new Point(); 
            Console.WriteLine("Enter two Point to compare");
            Console.WriteLine("Enter Point 1's X: ");
            p1.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Point 1's Y: ");
            p1.y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Point 2's X: ");
            p2.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Point 2's Y: ");
            p2.y = int.Parse(Console.ReadLine());

            //Test
            Console.WriteLine(p1.PrintPoint());
            Console.WriteLine(p2.PrintPoint());
            //Console.WriteLine(p1.x);
            //p.PrintPoint();

            if (p2.x > p1.x)
            {
                Console.WriteLine("P2 is to the right of P1");
            }
            else if (p2.x < p1.x)
            {
                Console.WriteLine("P2 is to the left of P1");
            }
            else
            {
                Console.WriteLine("P1 and P2 are on the same axis");
            }
        }
    }
}
