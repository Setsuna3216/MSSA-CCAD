using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Polymorphismdemo
{
    internal class Employee
    {
        protected static int nextid = 1;
        public int Id { get; protected set; }
        public string Name { get; set; }
        public Employee()
        {
            Id = nextid++;
        }
        public Employee(string name)
        {
            Id = nextid++;
            Name = name;
        }
    }
    class PartTimeEmp:Employee
    {

        public PartTimeEmp()
        {
           // base.Id = nextid++;

        }
    }
}
