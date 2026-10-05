using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1._4._2
{
    internal class Student
    {
        private int studentId;
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        private string studentFname;
        public string StudentFname
        {
            get { return studentFname; }
            set {  studentFname = value; }
        }
        private string studentLname;
        public string StudentLname
        {
            get { return studentLname; }
            set { studentLname = value; }
        }
        private char studentGrade;
        public char StudentGrade
        {
            get { return studentGrade; }
            set { studentGrade = value; }
        }

        public Student(int studentId, string studentFname, string studentLname, char studentGrade)
        {
            this.studentId = studentId;
            this.studentFname = studentFname;
            this.studentLname = studentLname;
            this.studentGrade = studentGrade;
        }

        public string printStudentInfo()
        {
            return $"Student ID: {StudentId} \nStudent First name: {StudentFname} \nStudent Last name: {StudentLname} \nStudent Grade: {StudentGrade}";
        }

    }
}
