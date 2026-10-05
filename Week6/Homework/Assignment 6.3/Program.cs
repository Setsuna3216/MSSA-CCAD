namespace Assignment_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CallQueue queue = new CallQueue();
            Caller caller1 = new Caller();
            caller1.name = "Tom";
            queue.Enqueue(caller1);

            Caller caller2 = new Caller();
            caller2.name = "Amy";
            queue.Enqueue(caller2);

            Caller caller3 = new Caller();
            caller3.name = "Bob";
            queue.Enqueue(caller3);

            queue.Display();

            Console.WriteLine("After Dequeue:");

            queue.Dequeue();
            queue.Display();

        }
    }
}
