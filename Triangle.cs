using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    internal class Triangle
    {
        private int edge,height;
        private double area;
        private double perimeter;
        public Triangle(int edge,int height)
        {
            this.edge = edge;
            this.height = height;   
        }


        public double calculateArea()
        {
            area = edge * edge;
            return area;
        }
        public double calculatePerimeter()
        {
            perimeter = edge * 3;
            return perimeter;
        }
    }
}
