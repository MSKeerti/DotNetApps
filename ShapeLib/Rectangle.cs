using ShapeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Rectangle :Paint, IShape
        {
        public int length = 9;
        public int breadth = 10;

        public void Draw()
        {
            Console.WriteLine("It draws a Rectangle");
        }

        public void GetDetails()
        {
            Console.WriteLine("It takes the given length and breadth value");
        }

        public override int CalculateArea()
        {
            int areaRectangle = length * breadth;
            Console.WriteLine($"The area of the rectangle is {areaRectangle}");
            return areaRectangle;
        }

        public override string FillColor(string color)
        {
            return $"Filling the rectangle with {color} color";
        }
    }
}

