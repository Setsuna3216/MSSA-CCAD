namespace Assignment_1._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student First name: ");
            string studentFname = Console.ReadLine();
            Console.WriteLine("Enter Student Last name: ");
            string studentLname = Console.ReadLine();
            Console.WriteLine("Enter Student Grade: ");
            char studentGrade = char.Parse(Console.ReadLine());

            Student studentInfo = new Student(studentId, studentFname, studentLname, studentGrade);

            Console.WriteLine(studentInfo.printStudentInfo());
        }
    }
}
