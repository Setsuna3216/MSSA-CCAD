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
using System.Linq;

namespace Assignment_10._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadCars();
        }

        private void LoadCars()
        {
            using var db = new CarDbContext();

            var cars = db.Cars.ToList();

            CarsGrid.ItemsSource = cars;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Button clicked!");
            string vin = VinTextBox.Text;
            string make = MakeTextBox.Text;
            string model = ModelTextBox.Text;

            if (!int.TryParse(YearTextBox.Text, out int year))
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            if (!decimal.TryParse(PriceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            Car newCar = new Car
            {
                VIN = vin,
                Make = make,
                Model = model,
                Year = year,
                Price = price
            };

            using var db = new CarDbContext();
            db.Cars.Add(newCar);
            db.SaveChanges();
            LoadCars();
        }

        private void CarsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CarsGrid.SelectedItem is Car selectedCar)
            {
                VinTextBox.Text = selectedCar.VIN;
                MakeTextBox.Text = selectedCar.Make;
                ModelTextBox.Text = selectedCar.Model;
                YearTextBox.Text = selectedCar.Year.ToString();
                PriceTextBox.Text = selectedCar.Price.ToString();

            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Update button clicked!");
            if (CarsGrid.SelectedItem is not Car selectedCar)
            {
                MessageBox.Show("Please select a car to update.");
                return;
            }

            int selectedId = selectedCar.Id;

            using var db = new CarDbContext();

            Car? car = db.Cars.Find(selectedId);
            if (car == null)
            {
                MessageBox.Show("Car not found.");
                return;
            }

            if (!int.TryParse(YearTextBox.Text, out int year))
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            if (!decimal.TryParse(PriceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }
            car.VIN = VinTextBox.Text;
            car.Make = MakeTextBox.Text;
            car.Model = ModelTextBox.Text;
            car.Year = year;
            car.Price = price;
            
            db.SaveChanges();
            LoadCars();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (CarsGrid.SelectedItem is not Car selectedCar)
            {
                MessageBox.Show("Please select a car to delete.");
                return;
            }

            
            MessageBoxResult result = MessageBox.Show(
                "Are you sure you want to delete this car?",
                "Confirm Delete",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning
            );

            if (result != MessageBoxResult.Yes)
            {
                return;
            }

            
            using var db = new CarDbContext();

            Car? car = db.Cars.Find(selectedCar.Id);

            if (car == null)
            {
                MessageBox.Show("Car not found.");
                return;
            }

            
            db.Cars.Remove(car);

            
            db.SaveChanges();

            
            LoadCars();

            MessageBox.Show("Car deleted successfully.");
        }
    }
}