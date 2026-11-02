using Mod7CodeFirstDEmo.Models;
using Mod7CodeFirstDEmo.Services;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod7CodeFirstDEmo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CRUD cRUD = new CRUD();
        private void RefreshGrid()
        {
            empGrid.ItemsSource = null;
            empGrid.ItemsSource = cRUD.GetEmployees();
            empGrid.Columns[4].Visibility = Visibility.Collapsed;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshGrid();
            btnSubmit.IsEnabled = false;
            btnUpdate.IsEnabled = false;
            comboDept.Items.Clear();
            foreach(var dept in cRUD.GetDepartments())
            {
                comboDept.Items.Add(dept.DepartmentName);
            }

        }
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = (cRUD.GetEmployees().Max(x => x.EmployeeId) + 1).ToString();
            txtId.IsReadOnly = true;
            txtName.Clear();
            txSalary.Clear();
            comboDept.SelectedIndex = -1;
            btnSubmit.IsEnabled = true;

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtName.Text)&&
                comboDept.SelectedIndex!=-1)
            {
                Employee newobj = new Employee();
                newobj.EmployeeId = int.Parse(txtId.Text);
                newobj.EmployeeName = txtName.Text;
                newobj.Salary = double.Parse(txSalary.Text);
                newobj.DepartmentId = comboDept.SelectedIndex + 1;
                cRUD.AddEmployee(newobj);
                RefreshGrid();
                btnSubmit.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }

        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = empGrid.SelectedItem as Employee;
            if(emp!=null)
            {
                txtId.Text = emp.EmployeeId.ToString();
                txtName.Text = emp.EmployeeName;
                txSalary.Text = emp.Salary.ToString();
                comboDept.SelectedIndex = emp.DepartmentId - 1;
                btnUpdate.IsEnabled = true;
                btnSubmit.IsEnabled = false;
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = empGrid.SelectedItem as Employee;
            if(emp!=null)
            {
                cRUD.DeleteEmployee(emp.EmployeeId);
                RefreshGrid();
            }

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtId.Text))
            {

                var emp = cRUD.GetEmployee(int.Parse(txtId.Text));
                if(emp!=null)
                {
                    emp.EmployeeName = txtName.Text;
                    emp.Salary = double.Parse(txSalary.Text);
                    emp.DepartmentId = comboDept.SelectedIndex + 1;
                    cRUD.UpdateEmployee(emp.EmployeeId, emp);
                    RefreshGrid();
                    btnUpdate.IsEnabled = false;
                }


            }

        }
    }
}