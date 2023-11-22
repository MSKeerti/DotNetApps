using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
    public interface IShape
    {
        void Draw();
        void GetDetails();
    }
     public abstract class Paint
    {
        public abstract int CalculateArea();
        public abstract string FillColor(string color);
    }
   
}
