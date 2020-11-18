using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public Address Address { get; set; }

        public Student()
        {
            FirstName = "";
            LastName = "";
            Major = "";
            GPA = 0;

        }

        public Student(string firstname, string lastname,string major, double gpa)
        {
            FirstName = firstname;
            LastName = lastname;
            Major = major;
            GPA = gpa;
        }

        string Distinction;
        public string CalculateDistinction()
        {
            if (GPA >= 3.4 && GPA <= 3.59)
            {
                Distinction = "cum laude";
            }
            else if (GPA >= 3.6 && GPA <= 3.79)
            {
                Distinction = "magna cum laude";
            }
            else if (GPA >= 3.8 && GPA <= 4)
            {
                Distinction = "summa cum laude";
            }
            else
            {
                Distinction = "no distinction";
            }

            return Distinction;
        }

        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipcode)
        {
            Address Addy = new Address();
            Addy.StreetNumber = streetNumber;
            Addy.StreetName = streetName;
            Addy.State = state;
            Addy.City = city;
            Addy.Zipcode = zipcode;
        }

        public override string ToString()
        {
            string Output = ($"{FirstName} {LastName}, {Major}, {CalculateDistinction()}.");
            return Output;
        }
    }
}
