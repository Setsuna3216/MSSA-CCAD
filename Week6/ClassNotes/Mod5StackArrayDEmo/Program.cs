namespace Mod5StackArrayDEmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intstack = new Stack<int>();
            intstack.Push(10);
            intstack.Pop();

            StackArray mystack = new StackArray(20);
           // mystack.Display();

            mystack.Push(12);
            mystack.Push(34);
            Console.WriteLine("after pushing..");
            mystack.Display();

            mystack.Push(56);
            Console.WriteLine("after pushing..");
            mystack.Display();
            Console.WriteLine($"after popping " +mystack.Pop());
            mystack.Display();
            //LIFO
        }
    }
}
