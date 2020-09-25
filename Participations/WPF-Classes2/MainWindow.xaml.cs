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

namespace WPF_Classes2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Toy NewToy = new Toy();
            
            
            
           
            NewToy.Price = Convert.ToDouble(txtPrice.Text);

            if (string.IsNullOrEmpty(txtManufacturer.Text))
            {
                MessageBox.Show("Please enter a manufacturer");
            }
            else
            {
                NewToy.Manufacturer = txtManufacturer.Text;
            }
            
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter a toy name");
            }
            else
            {
                NewToy.Name = txtName.Text;
            }

            

            

            if (double.TryParse(txtPrice.Text.ToString(), out double f))
            {
                NewToy.Price = Convert.ToDouble(txtPrice.Text);
            }
            else
            {
                MessageBox.Show("Please enter a valid price");
            }

            lbToys.Items.Add(NewToy);
        }

        private void lbToys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Toy selectedToy = (Toy)lbToys.SelectedItem;
            MessageBox.Show(selectedToy.GetAisle());
        }
    }
}
