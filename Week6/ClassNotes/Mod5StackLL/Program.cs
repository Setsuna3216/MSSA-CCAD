namespace Mod5StackLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackLL mystack = new StackLL();
            mystack.Push(34);
            mystack.Push(56);
            mystack.Push(90);
            mystack.Push(120);
            mystack.Display();
            Console.WriteLine($"popped value:{mystack.Pop()}");
            mystack.Display();

        }
    }
}
