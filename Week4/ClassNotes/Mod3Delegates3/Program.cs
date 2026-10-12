namespace Mod3Delegates3
{
    internal class Program
    {
        static bool PromotablebyGrade(Employee emp)
        {
            if (emp.Grade == 'A')
                return true;
            return false;

        }
        static bool PromotablebyExp(Employee emp)
        {
            if (emp.YearsOfExp >= 5) return true;
            return false;
        }
        static void DisplayPromotableEmployees(IsPromotable isPromotable,List<Employee>list)
        {
            foreach(var emp in list)
            {
                if (isPromotable(emp))
                    Console.WriteLine(emp.Name);
            }

        }
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Eid = 1, Name = "Neil", YearsOfExp = 2, Grade = 'A' });
            list.Add(new Employee() { Eid = 2, Name = "Nathan", YearsOfExp = 5, Grade = 'B' });
            list.Add(new Employee() { Eid = 3, Name = "Kelly", YearsOfExp = 1, Grade = 'A' });
            list.Add(new Employee() { Eid = 4, Name = "Fred", YearsOfExp = 6, Grade = 'A' });
            list.Add(new Employee() { Eid = 5, Name = "Steven", YearsOfExp = 3, Grade = 'B' });

            Console.WriteLine("List of employees..");
            foreach(var emp in list)
            {
                Console.WriteLine($"{emp.Name} {emp.Grade} {emp.YearsOfExp}");
            }
            Console.WriteLine("Employees promotable by experience:");
            DisplayPromotableEmployees(PromotablebyExp, list);

            Console.WriteLine("Employees promotable by grade:");
            DisplayPromotableEmployees(PromotablebyGrade, list);

        }
    }
}
