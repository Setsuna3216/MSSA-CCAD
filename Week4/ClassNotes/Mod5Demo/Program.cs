namespace Mod5Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Espresso e = new Espresso();
            List<Beverage> list = new List<Beverage>();
            list.Add(new Espresso() { Id=1 });
            CustomList<int> mylist = new CustomList<int>();

            Dictionary<int, string> mydictionary = new Dictionary<int, string>();

            CustomDictionary<int, string> custdictionary = new CustomDictionary<int, string>();


            int i = 0;
            i.CheckValue(9);

            int k = 100;

            string s = "passw0rd";
            Console.WriteLine(s.ContainsDigits());
            string test = "test";


            Console.WriteLine(int.MaxValue);
            int[] prices = new int[] { 3, 4, 5 };
        
        }
    }
}
