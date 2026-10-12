namespace Mod4CollectionClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("7");
            names.Add("Frank");
            names.Add("Amy");
            Console.WriteLine(names.Capacity);
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            for(int i=0;i<names.Count;i++)
            {
                Console.WriteLine(names[i]);
            }
            //fifo
            Queue<string> customerQ = new Queue<string>();
            customerQ.Enqueue("Cust1");
            customerQ.Enqueue("Cust2");
            Console.WriteLine($"After 1 DQ :{customerQ.Dequeue()} ");
            Console.WriteLine("Remaining in Q:");
            foreach(var cust in customerQ)
            {
                Console.WriteLine(cust);

            }
            Stack<string> operations = new Stack<string>();
            operations.Push("write");
            operations.Push("font");
            operations.Push("color");

            Console.WriteLine($"pop : {operations.Pop()}");

            Console.WriteLine("Remaining operations in stack");
            foreach(var op in operations)
            {
                Console.WriteLine(op);
            }

            Dictionary<string, string> Recipes = new Dictionary<string, string>();

            Recipes.Add("Clear Soup", "Ingredient, step by step"); 
            Recipes.Add("Burger", "");
            if(Recipes.ContainsKey("Clear Soup"))
            {

            }
            foreach(var key in Recipes.Keys)
            {
                //key-value
                Console.WriteLine(key + "-" + Recipes[key]);
            }
            Recipes.Remove("Burger");
            

            //for(int i=0;i<Recipes.Values.Count;i++)
            //{
            //    Console.WriteLine(Recipes.Values[i]);
            //}
        }
    }
}
