namespace Assignment_3._4
{
    public partial class Form1 : Form
    {

        List<Coffee> coffees = new List<Coffee>();
        public Form1()
        {
            InitializeComponent();

            cmbSize.Items.Add("Small");
            cmbSize.Items.Add("Medium");
            cmbSize.Items.Add("Large");

            cmbRoast.Items.Add("Light");
            cmbRoast.Items.Add("Medium");
            cmbRoast.Items.Add("Dark");

            cmbSize.SelectedIndex = 0;
            cmbRoast.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee();

            coffee.Name = txtName.Text;
            coffee.Price = decimal.Parse(txtPrice.Text);
            coffee.Size = cmbSize.Text;
            coffee.Roast = cmbRoast.Text;
            coffee.HasMilk = chkMilk.Checked;

            coffees.Add(coffee);

            dgvCoffee.DataSource = null;
            dgvCoffee.DataSource = coffees;
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCoffee.CurrentRow != null)
            {
                Coffee coffee = (Coffee)dgvCoffee.CurrentRow.DataBoundItem;

                coffees.Remove(coffee);

                dgvCoffee.DataSource = null;
                dgvCoffee.DataSource = coffees;
            }
        }
    }
}
