using ClassesFilesDateTime;
using System;
using System.Collections.Generic;

namespace InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.height = 10;
            rect1.width = 20;

            Rectangle rect2 = new Rectangle(5, 2);
            
            Console.WriteLine($"The area of rect1 is {rect1.area()}");
            Console.WriteLine($"The area of rect2 is {rect2.area()}");

            List<Rectangle> rectangles = new List<Rectangle>();
            rectangles.Add(rect1);
            rectangles.Add(rect2);
            rectangles.Add(new Rectangle(7, 7));

            foreach (var rect in rectangles)
            {
                Console.WriteLine(rect);
            }
        }
    }
}
