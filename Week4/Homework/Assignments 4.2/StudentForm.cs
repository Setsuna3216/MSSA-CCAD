using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Assignments_4._2
{
    public partial class StudentForm : Form
    {
        private List<Student> students = new List<Student>();
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow != null)
            {
                Student student = (Student)dgvStudent.CurrentRow.DataBoundItem;

                students.Remove(student);

                dgvStudent.DataSource = null;
                dgvStudent.DataSource = students;
            }
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            if (!int.TryParse(txtStudentId.Text, out int studentId))
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }
            if (!double.TryParse(txtGpa.Text, out double Gpa))
            {
                MessageBox.Show("Please enter a valid GPA.");
                return;
            }
            if (Gpa < 0 || Gpa > 4.0)
            {
                MessageBox.Show("GPA must be between 0.0 and 4.0.");
                return;
            }

            student.StudentId = studentId;
            student.StudentName = txtStudentName.Text;
            student.GPA = Gpa;

            students.Add(student);

            dgvStudent.DataSource = null;
            dgvStudent.DataSource = students;

        }

        private void btnSaveHighest_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("No students available.");
                return;
            }
            Student highestStudent = students[0];
            foreach (Student student in students)
            {
                if (student.GPA > highestStudent.GPA)
                {
                    highestStudent = student;
                }
            }
            string studentDetails = $"Student ID: {highestStudent.StudentId}\n" +
                                    $"Student Name: {highestStudent.StudentName}\n" +
                                    $"GPA: {highestStudent.GPA}";
            File.WriteAllText("HighestGPA.txt", studentDetails);

            MessageBox.Show("Highest GPA student saved successfully.");


        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
