using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3._3
{
    enum Month
    {
        Jan,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }
    enum Grade
    {
        A,
        B,
        C,
        D,
        E,
        F
    }

    internal class Student
    {

        public int Studid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Month MonthAdmission { get; set; }
        public Grade StudentGrade { get; set; }

    }

    
}
