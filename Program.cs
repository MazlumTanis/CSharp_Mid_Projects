using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int figure,radius,shortEdge,longEdge,heigth;
            Console.WriteLine("For Circle: 1");
            Console.WriteLine("For Triangle: 2");
            Console.WriteLine("For Square: 3");
            Console.WriteLine("For Rectangle: 4");
            Console.Write("Please choose figure: "); 
            figure = int.Parse(Console.ReadLine());
            Console.Write("\n");

            switch (figure)
            {
                case 1:
                    Console.Write("Please enter the radius: ");
                    radius = int.Parse(Console.ReadLine());
                    Circle circle = new Circle(radius);
                    Console.Write("\n");
                    switch (calcType())
                    {
                        case 1:
                            Console.Write("Circle Area: ");
                            Console.WriteLine(circle.calculateArea());
                            break;
                        case 2:
                            Console.Write("Circle perimeter: ");
                            Console.WriteLine(circle.calculatePerimeter());
                            break;
                        case 3:
                            Console.Write("Circle volume: ");
                            Console.WriteLine(circle.calculateVolume());
                            break;
                    }
                    break;
                case 2:
                    Console.Write("Please enter the edge: ");
                    shortEdge = int.Parse(Console.ReadLine());
                    Console.Write("Please enter the height: ");
                    heigth = int.Parse(Console.ReadLine());
                    Triangle triangle = new Triangle(shortEdge,heigth);
                    Console.Write("\n");
                    switch (calcType())
                    {
                        case 1:
                            Console.Write("Circle Area: ");
                            Console.WriteLine(triangle.calculateArea());
                            break;
                        case 2:
                            Console.Write("Circle perimeter: ");
                            Console.WriteLine(triangle.calculatePerimeter());
                            break;
                        case 3:
                            Console.Write("Triangle has no volume");
                            break;
                    }
                    break;
                case 3:
                    Console.Write("Please enter the edge: ");
                    shortEdge = int.Parse(Console.ReadLine());
                    Square square = new Square(shortEdge);
                    Console.Write("\n");
                    switch (calcType())
                    {
                        case 1:
                            Console.Write("Circle Area: ");
                            Console.WriteLine(square.calculateArea());
                            break;
                        case 2:
                            Console.Write("Circle perimeter: ");
                            Console.WriteLine(square.calculatePerimeter());
                            break;
                        case 3:
                            Console.Write("Circle volume: ");
                            Console.WriteLine(square.calculateVolume());
                            break;
                    }
                    break;
                case 4:
                    Console.Write("Please enter the short edge: ");
                    shortEdge = int.Parse(Console.ReadLine());
                    Console.Write("\nPlease enter the long edge: ");
                    longEdge = int.Parse(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(shortEdge, longEdge);
                    Console.Write("\n");
                    switch (calcType())
                    {
                        case 1:
                            Console.Write("Circle Area: ");
                            Console.WriteLine(rectangle.calculateArea());
                            break;
                        case 2:
                            Console.Write("Circle perimeter: ");
                            Console.WriteLine(rectangle.calculatePerimeter());
                            break;
                        case 3:
                            Console.Write("Circle volume: ");
                            Console.WriteLine(rectangle.calculateVolume());
                            break;
                    }
                    break;

                    default:Console.WriteLine("Wrong selection!");
                    break;
            }




            Console.Read();
        }

       static public int calcType()
        {
            int calculationType;
            Console.WriteLine("For Area Press 1");
            Console.WriteLine("For Perimeter Press 2");
            Console.WriteLine("For Volume Press 3");
            Console.Write("Please choose calculation Type:");
            calculationType = int.Parse(Console.ReadLine());
            return calculationType;
        }
    }
}
