namespace Mod4Interfacesdemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 23, 45, 12, 11, 1, 100, 300 };

            numbers.Sort();
            Console.WriteLine("Sorted numbers:");
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            List<string> names = new List<string>() { "Zoe", "Amy", "Charlie" };
            names.Sort();
            Console.WriteLine("Sorted names");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            List<Student> studentlist = new List<Student>();
            studentlist.Add(new Student() { Id = 1, Name = "Zoe", Age = 13, GPA = 4.0f });
            studentlist.Add(new Student() { Id = 2, Name = "Amy", Age = 14, GPA = 4.2f });
            studentlist.Add(new Student() { Id = 3, Name = "Charlie", Age = 12, GPA = 3.0f });
            studentlist.Add(new Student() { Id = 4, Name = "Dan", Age = 15, GPA = 3.9f });

            studentlist.Sort();// icomparable :compareto
            Console.WriteLine("Students sorted as per names");
            foreach(var stud in studentlist)
            {
                Console.WriteLine($"{stud.Name}- {stud.GPA}-{stud.Age}");
                
            }

            Console.WriteLine("Age sorting:");
            //pass the class name which implements the comparer logic
            studentlist.Sort(new Student());// comparer logic in compare method is called
            foreach (var stud in studentlist)
            {
                Console.WriteLine($"{stud.Name}- {stud.GPA}-{stud.Age}");

            }
            Console.WriteLine("GPA sorting:");
            //pass the class name which implements the comparer logic
            studentlist.Sort(new StudentGPAComparer());// comparer logic in compare method is called
            foreach (var stud in studentlist)
            {
                Console.WriteLine($"{stud.Name}- {stud.GPA}-{stud.Age}");

            }


        }
    }
}
