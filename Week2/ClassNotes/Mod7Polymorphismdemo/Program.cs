namespace Mod7Polymorphismdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
              // Person obj = new Person();
            Student student = new Student();
            student.FirstName = "Nathan";
            student.LastName = "Keller";
            student.Age = 15;
            student.Email = "nathan@gmail.com";
            student.Introduce();
            student.DoWork();
            student.FollowSchedule();

            // cross referencing
            Person obj1,obj2;

            obj1 = new Instructor();
            obj2 = new Student();

            

            // Student s = new Person();
            //static class cannot be instantiated
           // Conversions obj = new Conversions();
            Console.WriteLine(Conversions.CelciusToFahrenheit(32.4));

            Employee e1 = new Employee("Mike");
            Employee e2 = new Employee("Sarah");
            PartTimeEmp e3 = new PartTimeEmp();

            Console.WriteLine($"Emp1 : {e1.Id}");
            Console.WriteLine($"Emp2 : {e2.Id}");
            Console.WriteLine($"Emp3 : {e3.Id}");

            int total = 0;
            for (int i = 1; i <= 50; i++)
            {
                for (int j = 1; j <= 50; j++)
                {
                    total++;
                }
            }

            Console.WriteLine($"total:{total}");
        }
    }
}
