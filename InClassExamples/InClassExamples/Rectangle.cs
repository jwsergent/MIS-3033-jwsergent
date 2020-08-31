using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesFilesDateTime
{
    public class Rectangle
    {
        public int width { get; set; }
        
        public int height { get; set; }
        public DateTime creationDate { get; set; }

        public Rectangle()
        {
            width = 0;
            height = 0;
            creationDate = DateTime.Now;
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public double area()
        {
            return width * height;
        }

        public override string ToString()
        {
            string output=  $"The rectangle has a width of {width} and a height of {height}. The area of the rectangle is {area()}";

            return output;
        }
    }
}
