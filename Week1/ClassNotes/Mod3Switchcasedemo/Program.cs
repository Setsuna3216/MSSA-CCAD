namespace Mod3Switchcasedemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favColor = string.Empty;

            char choice = 'y';
            while(choice=='y' || choice=='Y')
            {
                Console.WriteLine("Enter your favourite color from Red/Blue/Green");
                favColor = Console.ReadLine();
                //Red / red / RED
                switch(favColor.ToLower())
                {

                    case "red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Favourite color is red!!, great choice");
                        break;
                    case "blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Favourite color is blue!!, cool choice");
                        break;
                    case "green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Favourite color is green!!, great choice");
                        break;

                    default:
                        Console.ResetColor();
                        Console.WriteLine("no such color");
                        break;

                }
                Console.ResetColor();
                Console.WriteLine("Do you want to continue? (y/Y)");
                choice = Char.Parse(Console.ReadLine());
              
            }
        }
    }
}
