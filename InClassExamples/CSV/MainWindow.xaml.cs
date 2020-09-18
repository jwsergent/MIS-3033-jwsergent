using System;
using System.Collections.Generic;
using System.IO;
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

namespace CSV
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

        private void btnSelectFile_Click(object sender, RoutedEventArgs e)
        {
            string filepath = txtFilePath.Text;

            if (File.Exists(filepath))
            {
                btnProcess.IsEnabled = true;
                
            }
            else
            {
                MessageBox.Show("Invalid File, please try again");
                txtFilePath.Clear();
            }
        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
