using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //default accessor for class is internal in .exe applications like console
     class Person//parent, base
    {
        public string UUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DOB { get; set; }
        public string Address { get; set; }
        public void Display()
        {
            Console.WriteLine("I am person");
        }
        public Person()
        {

        }
        public Person(string id, string fname, string lname)
        {
            UUID = id;
            FirstName = fname;
            LastName = lname;
        }
        public Person(string id, string fname, string lname, DateOnly dob,string address)
        {
            UUID = id;
            FirstName = fname;
            LastName = lname;
            DOB = dob;
            Address = address;
        }
        private void Test()
        {

        }

    }


}
