using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Student:Person
    {
        //all public details ( prop +functions) get inherited along with protected

        // base keyword is used to refer to immediate base class
        public string Major { get; set; }
        public float GPA { get; set; }
    
        public void DisplaySchedule()
        {
            Console.WriteLine("I have lectures Mon-Thurs from 10 to 2");
        }
    }
}
