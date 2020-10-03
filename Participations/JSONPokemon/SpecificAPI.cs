using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPokemon
{
    public class SpecificAPI
    {

        [JsonProperty("results")]

        public List<AllResults> Results { get; set; }
    }

    public class SpecificResults
    {
        public double height { get; set; }
        public double weight { get; set; }


        public string PokInfo()
        {
            string heihtasstring = height.ToString();

            string weightasstring = weight.ToString();

            string PokInfoOutput = ($"This Pokemon has a height of {heihtasstring} and weighs {weightasstring}");

            return PokInfoOutput;
        }

        internal static object PokInfoOutput()
        {
            throw new NotImplementedException();
        }
    }
}
