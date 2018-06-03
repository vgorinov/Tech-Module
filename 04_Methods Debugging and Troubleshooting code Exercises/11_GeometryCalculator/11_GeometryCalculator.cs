using System;

namespace _11_GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", getTriangleArea(side, height));
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", getRectangleArea(width, height));
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", getSquareArea(side));
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", getCircleArea(radius));
            }
        }

        static double getTriangleArea(double side, double height)
        {
            double result = (side * height) / 2;
            return result;
        }

        static double getRectangleArea(double width, double height)
        {
            double result = width * height;
            return result;
        }

        static double getSquareArea(double side)
        {
            double result = side * side;
            return result;
        }

        static double getCircleArea (double radius)
        {
            double result = Math.PI * radius * radius;
            return result;
        }
    }
}
