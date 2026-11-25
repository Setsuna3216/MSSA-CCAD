using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joinexample
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public int? DeptId { get; set; }
    }


    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Pet
    {
        public string Name { get; set; }
        public Person Owner { get; set; }
    }

}
