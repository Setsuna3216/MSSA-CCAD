using Models;
namespace Mod7Inheritancedemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            //1001
            //1002
            Random random = new Random();
         //   random.Next(100);
           Person P = new Person();
          //  P.UUID = Guid.NewGuid().ToString();
            P.UUID = random.Next(100).ToString();
           Console.WriteLine("Enter first name..");
            P.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name..");
            P.LastName = Console.ReadLine();
            Console.WriteLine("Enter date of birth in mm/dd/yyyy format");
            P.DOB = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter address..");
            P.Address = Console.ReadLine();
            Console.WriteLine($"Name:{P.FirstName} ,  Id: {P.UUID}, DOB:{P.DOB}");

            P.Display();

            Student s = new Student();
            s.FirstName = "alex";
            s.LastName = "smith";
            s.UUID = random.Next(100).ToString();
            s.Major = "Biology";
            s.GPA = 3.6f;
         
            s.Display();
            s.DisplaySchedule();

            Teacher teacher = new Teacher();
            
            Sub subteacher = new Sub();
            


          
        }
    }
}
