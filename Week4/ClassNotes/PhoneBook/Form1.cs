namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            phonebookGrid.DataSource = Data.PhoneBook.Values.ToList();


        MessageBox.Show(phonebookGrid.CurrentRow.Cells[0].Value.ToString());
           
        
        }
    }
}
