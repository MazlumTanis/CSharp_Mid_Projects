using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    internal class Circle
    {
        private int radius;
        private double area;
        private double perimeter;
        private double volume;
        const double pi = 3.14;
        public Circle(int radius)
        {
            this.radius = radius;
        }

       public double calculateArea()
        {
            area = pi*(radius^2);
            return area;
        }
        public double calculatePerimeter()
        {
            perimeter = pi * radius * 2;
            return perimeter;
        }
        public double calculateVolume()
        {
            volume = 4/3*(pi * (radius ^ 3));
            return volume;
        }
    }
}
