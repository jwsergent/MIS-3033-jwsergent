﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace ChuckNorrisJokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();

            txtJoke.IsEnabled = false;

            string[] cats;

            using (var client = new HttpClient())
            {
                string jsonResults = client.GetStringAsync(@"https://api.chucknorris.io/jokes/categories").Result;

                cats = JsonConvert.DeserializeObject<string[]>(jsonResults);
            }

            cboCategories.Items.Add("All");

            foreach (var item in cats)
            {
                cboCategories.Items.Add(item);
            }

            
        }

        

        private void cboCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedcategory = cboCategories.SelectedItem;

            if (selectedcategory=="All")
            {
                string jokeurl = "https://api.chucknorris.io/jokes/random";

                Joke RandomJoke;

                using (var client = new HttpClient())
                {
                    string jsonres = client.GetStringAsync(jokeurl).Result;

                    RandomJoke = JsonConvert.DeserializeObject<Joke>(jsonres);
                }


                txtJoke.Text = RandomJoke.ToString();

            }
            else
            {
                string jokeurl = "https://api.chucknorris.io/jokes/random?category=" + selectedcategory;

                Joke NewJoke;

                using (var client = new HttpClient())
                {
                    string json = client.GetStringAsync(jokeurl).Result;

                    NewJoke = JsonConvert.DeserializeObject<Joke>(json);
                }

                txtJoke.Text = NewJoke.ToString();
            }
            
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            txtJoke.IsEnabled=true;
        }
    }
}
