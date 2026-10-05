namespace Mod4LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> ilist = new List<int>();
            ilist.Add(9);
            //ilist[0] = 8;

            LinkedList<int> intlist = new LinkedList<int>();
          
            intlist.AddFirst(34);
            intlist.AddLast(56);
           // Console.WriteLine("List :");
            foreach(var item in intlist)
            {
              ///  Console.Write(item + " ");
            }

            intlist.AddFirst(12);
            Console.WriteLine();
            //Console.WriteLine("Updated List :");
            foreach (var item in intlist)
            {
               // Console.Write(item+ " ");
            }

            Linkedlist mylist = new Linkedlist();
            mylist.AddFirst(23);
            mylist.AddFirst(12);
            mylist.AddFirst(78);
            mylist.Display();
            mylist.AddLast(200);
            mylist.AddLast(100);
            Console.WriteLine("Updated list..");
            mylist.Display();
            mylist.RemoveFirst();
            Console.WriteLine("Updated list..");
            mylist.Display();

            mylist.RemoveLast();

            Console.WriteLine("Updated list..");
            mylist.Display();

            mylist.AddAnyWhere(10, 2);
            Console.WriteLine("Updated list..");
            mylist.Display();
            mylist.RemoveAnywhere(3);
            Console.WriteLine("Updated list..");
            mylist.Display();


        }
    }
}
