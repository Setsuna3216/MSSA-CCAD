namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstNum;
        double secondNum;
        string operation;
        bool isCalculationFinished;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (isCalculationFinished == true)
            {
                txtDisplay.Clear();
                isCalculationFinished = false;
            }

            
            Button myButton = (Button)sender;

            if(myButton.Text == ".")
            {
                if (txtDisplay.Text.Contains("."))
                {
                    //ignore sencond .
                }
                else
                {
                    txtDisplay.Text = txtDisplay.Text + myButton.Text;
                }
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + myButton.Text;

            }


        }

        private void opreation_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            Button myButton = (Button)sender;
            operation = myButton.Text;
            txtDisplay.Clear();

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNum = double.Parse(txtDisplay.Text);
            ICalculator calculate = new Math();

            if (operation == "+")
            {
                txtDisplay.Text = (calculate.Add(firstNum, secondNum)).ToString();
            }
            else if (operation == "-")
            {
                txtDisplay.Text = (calculate.Subtract(firstNum, secondNum)).ToString();
            }
            else if (operation == "*")
            {
                txtDisplay.Text = (calculate.Multiply(firstNum, secondNum)).ToString();
            }
            else if (operation == "/")
            {
                if(secondNum == 0)
                {
                    MessageBox.Show("Cannot divide by 0");
                    txtDisplay.Clear();
                }
                else
                {
                    txtDisplay.Text = (calculate.Divide(firstNum, secondNum)).ToString();
                }
                
            }
            isCalculationFinished = true;

        }
    }

}
