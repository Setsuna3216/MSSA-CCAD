namespace Assignments_4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserId.Text=="Teacher" && txtPassword.Text == "Admin")
            {
                MessageBox.Show("Login successful!");
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid user ID or password.");
            }
        }
    }
}
