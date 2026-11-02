using Mod7ProductDBApp.Models;
using Mod7ProductDBApp.Services;
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

namespace Mod7ProductDBApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ICRUD crud;
        Product newProduct = new Product();
        Product? selectedproduct = null;
        public MainWindow(ICRUD _crud)
        {
             InitializeComponent();
            crud = _crud;
            ProductGrid.ItemsSource = crud.GetProducts();
            AddProductGrid.DataContext = newProduct;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            crud.AddProduct(newProduct);
            MessageBox.Show("Product is added!");
            ProductGrid.ItemsSource = crud.GetProducts();
            newProduct = new Product();
            AddProductGrid.DataContext = newProduct;

        }
        private void EditProduct(object sender, RoutedEventArgs e)
        {
            selectedproduct = (sender as FrameworkElement)?.DataContext as Product;
            UpdateProductGrid.DataContext = selectedproduct;
        }
        private void DeleteProduct(object sender, RoutedEventArgs e)
        {
            var product = (sender as FrameworkElement)?.DataContext as Product;
            crud.DeleteProduct(product);
            MessageBox.Show("Product is deleted..");
            ProductGrid.ItemsSource = crud.GetProducts();

        }


        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            crud.UpdateProduct(selectedproduct);
            MessageBox.Show("Product is updated");
            ProductGrid.ItemsSource = crud.GetProducts();

        }
    }
}