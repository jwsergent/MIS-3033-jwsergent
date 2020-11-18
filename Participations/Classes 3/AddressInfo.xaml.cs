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
using System.Windows.Shapes;

namespace Classes_3
{
    /// <summary>
    /// Interaction logic for AddressInfo.xaml
    /// </summary>
    public partial class AddressInfo : Window
    {
               
        public AddressInfo()
        {
            InitializeComponent();


            txtAddressInfo.Text = Address.ToString();
        }

        private void txtAddressInfo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
