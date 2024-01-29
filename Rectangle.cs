using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvingGrounds
{
    public class Rectangle
    {
        private double Width;
        private double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            double area = Width * Height;
            return area;
        }

    }
}
