using Newtonsoft.Json;
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

namespace JSONPokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PokemonAPI pokemonApiResults;

            string apiURL = @"https://pokeapi.co/api/v2/pokemon/?offset=0&limit=1100";

            using (var client = new HttpClient())
            {
                string jsonResults = client.GetStringAsync(apiURL).Result;

                pokemonApiResults = JsonConvert.DeserializeObject<PokemonAPI>(jsonResults);
            }

            PokemonAPI specificapiresults;

            string specificapi = @"https://pokeapi.co/api/v2/pokemon/" + $"{cboPokemon.SelectedItem.ToString()}";
            using (var client = new HttpClient())
            {
                string specificResults = client.GetStringAsync(specificapi).Result;

                specificapiresults = JsonConvert.DeserializeObject<PokemonAPI>(specificResults);
            }
            
            // do more stuff
            // e.g. add results to a listbox/combobox
            foreach (var item in pokemonApiResults.Results)
            {
                cboPokemon.Items.Add(item);
            }

            

        }

        private void cboPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pokemon = (AllResults)cboPokemon.SelectedItem;

            lblCharInfo.Content = SpecificResults.PokInfoOutput();
        }
    }
}
