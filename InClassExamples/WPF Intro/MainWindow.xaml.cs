﻿using System;
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

namespace WPF_Intro
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

        private void btnGo_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You have entered the button");
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            string name, age;
            name = txtName.Text;
            age = txtage.Text;
            int ageAsNumber = Convert.ToInt32(age);

            txtage.Clear();
            txtName.Clear();

            MessageBox.Show($"Welcome {name} who is {ageAsNumber}");
        }
    }
}
