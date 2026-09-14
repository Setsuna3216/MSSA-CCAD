namespace Assignment_3._3
{
    public partial class Form1 : Form
    {

        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();

            cmbMonth.DataSource = Enum.GetValues(typeof(Month));
            cmbStudentGrade.DataSource = Enum.GetValues(typeof(Grade));
            //Student student = new Student();
            //student.FirstName = txtFirstName.Text;
            //student.LastName = txtLastName.Text;
            //student.Address = txtAddress.Text;



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            //student.Studid = int.Parse(txtStudentId.Text);
            if (!int.TryParse(txtStudentId.Text, out int studentId))
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Address = txtAddress.Text;
            student.MonthAdmission = (Month)cmbMonth.SelectedItem;
            student.StudentGrade = (Grade)cmbStudentGrade.SelectedItem;

            students.Add(student);

            dgvStudents.DataSource = null;
            dgvStudents.DataSource = students;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                Student student = (Student)dgvStudents.CurrentRow.DataBoundItem;

                students.Remove(student);

                dgvStudents.DataSource = null;
                dgvStudents.DataSource = students;
            }
        }
    }
}
