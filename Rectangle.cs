using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    internal class Rectangle
    {
        private int shortEdge,longEdge;
        private double area;
        private double perimeter;
        private double volume;

        public Rectangle(int shortEdge,int longEdge)
        {
            this.shortEdge = shortEdge;
            this.longEdge = longEdge;
        }

        public double calculateArea()
        {
            area = shortEdge * longEdge;
            return area;
        }
        public double calculatePerimeter()
        {
            perimeter = (shortEdge+ longEdge) * 2;
            return perimeter;
        }
        public double calculateVolume()
        {
            volume = shortEdge* longEdge*shortEdge ;
            return volume;
        }
    }
}

