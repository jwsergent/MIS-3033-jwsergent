﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPF1
{
    class EntryForm
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int ZipCode { get; set; }

        public EntryForm()
        {
            Name = "";
            Address = "";
            ZipCode = 0;
        }

        public EntryForm(string name, string address, int zipcode)
        {
            Name = name;
            Address = address;
            ZipCode = zipcode;
        }

        public override string ToString()
        {
            string Output = Name + " , " + Address + " , " + ZipCode;

            return Output;
        }
    }
}
