namespace Mod6ClassesDemo
{

    struct StructType
    {
        public int Id { get; set; }

    }
    class ClassType
    {
        public int Id { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StructType mystruct = new StructType();
            mystruct.Id = 100;
            ClassType myclass = new ClassType();
            myclass.Id = 100;
            ChangeData(mystruct, myclass);// mystruct is sent by value so a copy is created,
            // myclass is sent by reference, so original address is sent
            Console.WriteLine($"struct data: {mystruct.Id},class data:{myclass.Id}");


            int[] arr = { 1, 1, 1 };
            ChangeArray(arr);
            Console.WriteLine("changed array..");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        //
        static void ChangeData(StructType s,ClassType c)
        {
            s.Id = 200;
            c.Id = 200;
            Console.WriteLine("in function call");
            Console.WriteLine($"struct data: {s.Id},class data:{c.Id}");
        }

        static void ChangeArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
           

        }
    }
}
