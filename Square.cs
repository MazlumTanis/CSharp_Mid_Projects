using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    internal class Square
    {
        private int shortEdge;
        private double area;
        private double perimeter;
        private double volume;

        public Square(int shortEdge)
        {
            this.shortEdge = shortEdge;
        }

        public double calculateArea()
        {
            area = shortEdge * shortEdge;
            return area;
        }
        public double calculatePerimeter()
        {
            perimeter = shortEdge * 4;
            return perimeter;
        }
        public double calculateVolume()
        {
            volume =(shortEdge ^ 3);
            return volume;
        }
    }
}
