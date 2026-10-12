namespace Mod3Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu weekendSpecial = new Menu(3);
            // weekendSpecial.fooditems[0] = "";
            // weekendSpecial[0] = "";

            weekendSpecial[0] = "Sandwiches";// set
            weekendSpecial[1] = "Muffins";
            weekendSpecial[2] = "Triple flavour icecream";
            weekendSpecial[3] = "test";

          //  weekendSpecial[]

            Console.WriteLine("WeekendSpecial Menu:");
            for(int i=0;i<weekendSpecial.Count;i++)
            {
                Console.WriteLine(weekendSpecial[i]);// get
            }
        }
    }
}
