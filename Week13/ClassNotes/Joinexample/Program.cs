namespace Joinexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { DeptId = 1, DeptName = "HR" });
            departments.Add(new Department { DeptId = 2, DeptName = "Finance" });
            departments.Add(new Department { DeptId = 3, DeptName = "IT" });
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { EmpId = 1, EmpName = "Alex", DeptId = 1, Salary = 50000 });
            employees.Add(new Employee { EmpId = 2, EmpName = "Amy", DeptId = 2, Salary = 70000 });
            employees.Add(new Employee { EmpId = 3, EmpName = "Sid", DeptId = 3, Salary = 55000 });
            employees.Add(new Employee { EmpId = 4, EmpName = "Frank", DeptId = 1, Salary = 50000 });
            employees.Add(new Employee { EmpId = 5, EmpName = "Sarah", DeptId = null, Salary = 50000 });
           // inner join
            var result =
    from e in employees
    join d in departments
        on e.DeptId equals d.DeptId
    select new
    {
        EmployeeName = e.EmpName,
        DepartmentName = d.DeptName
    };

foreach (var item in result)
{
    Console.WriteLine(
        $"{item.EmployeeName} - {item.DepartmentName}");
}

            Console.WriteLine("Left outer join:");
//left outer join
            var resultnew =
                from e in employees
                join d in departments
                    on e.DeptId equals d.DeptId
                    into departmentGroup
                from d in departmentGroup.DefaultIfEmpty()
                select new
                {
                    EmployeeName = e.EmpName,
                    DepartmentName = d == null
                        ? "No Department"
                        : d.DeptName
                };

            foreach (var item in resultnew)
            {
                Console.WriteLine(
                    $"{item.EmployeeName} - {item.DepartmentName}");
            }


            Person Jack = new Person() { FirstName = "Jack", LastName = "S" };
            Person Nathan = new Person() { FirstName = "Nathan", LastName = "S" };
            Person Steven = new Person() { FirstName = "Steven", LastName = "S" };
            Person Terry = new Person() { FirstName = "Terry", LastName = "S" };
            Pet Elli = new Pet { Name = "Elli", Owner = Terry };
            Pet Sofi = new Pet { Name = "Sofi", Owner = Terry };
            Pet Bruno = new Pet { Name = "Bruno", Owner = Steven };

            List<Person> people = new List<Person>() { Terry, Jack, Steven, Nathan };
            List<Pet> pets = new List<Pet>() { Elli, Sofi, Bruno };

            var result2 = from person in people
                          join pet in pets on person equals pet.Owner
                          select new
                          {
                              Ownername = person.FirstName,
                              Petname = pet.Name
                          };
            foreach(var p in result2)
            {
                Console.WriteLine($"{p.Ownername} is parent of {p.Petname}");
            }
            
        }
    }
}
