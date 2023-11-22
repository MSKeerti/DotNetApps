using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public class Circle : Paint,IShape
    {
        public int radius = 4;

        public void Draw()
        {
            Console.WriteLine("It draws a Circle");
        }

        public void GetDetails()
        {
            Console.WriteLine("It takes the given radius value");
        }

        public override int CalculateArea()
        {
            double areaCircle = 3.14 * radius * radius;
            Console.WriteLine($"The area of the circle is {areaCircle}");
            return (int)areaCircle;
        }

        public override string FillColor(string color)
        {
            return $"Filling the circle with {color} color";
        }
    }

}

