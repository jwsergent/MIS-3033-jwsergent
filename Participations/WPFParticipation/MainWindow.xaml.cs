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

namespace WPFParticipation
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string name, age;


            name = txtName.Text;
            age = txtBirthday.Text;

            DateTime BirthdayAsDate = Convert.ToDateTime(age);
            var howOldTheyAre = DateTime.Now - BirthdayAsDate;
            double old = Convert.ToDouble(howOldTheyAre.TotalDays / 365);

            string OldFormatted= old.ToString("N2");

            MessageBox.Show($"{name} is {OldFormatted} years old!");


        }

        private void btnCalculate_MouseEnter(object sender, MouseEventArgs e)
        {
            btnCalculate.Background = new SolidColorBrush(Colors.Blue);
        }

        private void btnCalculate_MouseLeave(object sender, MouseEventArgs e)
        {
            btnCalculate.Background = new SolidColorBrush(Colors.LightGray);
        }
    }
}
