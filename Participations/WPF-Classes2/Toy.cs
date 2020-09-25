using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Classes2
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        private string Aisle { get; set; }

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Aisle = "";
        }

        char ManuFirstLetter;
        string UpperManu;
        public string GetAisle()
        {
            UpperManu = Manufacturer.ToUpper();

            ManuFirstLetter = UpperManu[0];

            double NewPrice = Price * 100;
            string PriceAisle = NewPrice.ToString("n0");


            string Aisle = ManuFirstLetter + PriceAisle;
            

            return Aisle;
        }

        public override string ToString()
        {
            string Output = Manufacturer + " - " + Name;

            return Output;
        }
    }
}
