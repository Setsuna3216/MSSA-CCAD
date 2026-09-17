namespace Assignment_4._1
{
    public partial class Form1 : Form
    {
        Dictionary<string, Person> phoneBook = new Dictionary<string, Person>();
        public Form1()
        {
            InitializeComponent();


            //
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.MobilePhone = txtMobilePhone.Text;
            person.WorkPhone = txtWorkPhone.Text;
            person.Address = txtAddress.Text;

            string key = person.FirstName + " " + person.LastName;
            if (phoneBook.ContainsKey(key))
            {
                // 1 key only can use once
                MessageBox.Show("The Name is already used");
                return;
            }
            phoneBook.Add(key, person);
            dgvPhoneBook.DataSource = phoneBook.Values.ToList();



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPhoneBook.CurrentRow != null)
            {
                Person deletePerson = (Person)dgvPhoneBook.CurrentRow.DataBoundItem;
                string key = deletePerson.FirstName + " " + deletePerson.LastName;

                DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this person?",
                        "Confirm Delete",
                         MessageBoxButtons.YesNo
                        );
                if (result == DialogResult.Yes)

                {
                    phoneBook.Remove(key);
                    dgvPhoneBook.DataSource = phoneBook.Values.ToList();
                }
                else
                {
                    return;
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string key = txtFirstName.Text + " " + txtLastName.Text;
            if (phoneBook.ContainsKey(key))
            {
                Person foundPerson = phoneBook[key];
                MessageBox.Show
                    (
                    "First Name: " + foundPerson.FirstName + "\n" +
                    "Last Name: " + foundPerson.LastName + "\n" +
                    "MobilePhone: " + foundPerson.MobilePhone + "\n" +
                    "WorkPhone: " + foundPerson.WorkPhone + "\n" +
                    "Address " + foundPerson.Address
                    );

            }
            else
            {
                MessageBox.Show("Person not found");

            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDisplayAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
