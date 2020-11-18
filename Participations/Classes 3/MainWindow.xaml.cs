using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Classes_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtFirstName.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student Stud = new Student();
            Address Addy = new Address();

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please enter a First Name");
            }
            else
            {
                Stud.FirstName = txtFirstName.Text;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please enter a Last Name");
            }
            else
            {
                Stud.LastName = txtLastName.Text;
            }

            if (string.IsNullOrEmpty(txtMajor.Text))
            {
                MessageBox.Show("Please enter a Major");
            }
            else
            {
                Stud.Major = txtMajor.Text;
            }

            if (double.TryParse(txtGPA.Text.ToString(), out double f))
            {
                Stud.GPA = Convert.ToDouble(txtGPA.Text);
            }
            else
            {
                MessageBox.Show("Please enter a valid GPA");
            }



            if (string.IsNullOrEmpty(txtStreetName.Text))
            {
                MessageBox.Show("Invalid Street Number");
            }
            else
            {
                Addy.StreetName = txtStreetName.Text;
            }

            if (string.IsNullOrEmpty(txtState.Text))
            {
                MessageBox.Show("Invalid State");
            }
            else
            {
                Addy.State = txtState.Text;
            }

            if (string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("Invalid City");
            }
            else
            {
                Addy.City = txtCity.Text;
            }

            if (int.TryParse(txtStreetNumber.Text.ToString(), out int r))
            {
                Addy.StreetNumber = Convert.ToInt32(txtStreetNumber.Text);
            }
            else
            {
                MessageBox.Show("Invalid Street Number");
            }

            if (int.TryParse(txtZipcode.Text.ToString(), out int y))
            {
                Addy.StreetNumber = Convert.ToInt32(txtZipcode.Text);
            }
            else
            {
                MessageBox.Show("Invalid Zipcode");
            }

            if (string.IsNullOrEmpty(txtFirstName.Text) | string.IsNullOrEmpty(txtLastName.Text) | string.IsNullOrEmpty(txtMajor.Text) | double.TryParse(txtGPA.Text.ToString(), out double g) == false |
                string.IsNullOrEmpty(txtStreetName.Text) | string.IsNullOrEmpty(txtState.Text) | string.IsNullOrEmpty(txtCity.Text) | int.TryParse(txtStreetNumber.Text.ToString(), out int h) == false | int.TryParse(txtZipcode.Text.ToString(), out int l) == false)
            {
                MessageBox.Show("Cannot add student");
            }
            else
            {
                lbStudents.Items.Add(Stud);
            }

            txtZipcode.Clear();
            txtStreetNumber.Clear();
            txtStreetName.Clear();
            txtState.Clear();
            txtMajor.Clear();
            txtLastName.Clear();
            txtGPA.Clear();
            txtFirstName.Clear();
            txtCity.Clear();
            txtFirstName.Focus();
        }

        private void lbStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedStudent = lbStudents.SelectedItem;

            AddressInfo AddressInfoWindow = new AddressInfo();

            AddressInfoWindow.
        }
    }
}
