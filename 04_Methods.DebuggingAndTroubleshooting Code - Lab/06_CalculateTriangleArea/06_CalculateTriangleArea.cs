using System;

namespace _06_CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double triangleArea = GetTriangleArea(width, height);

            Console.WriteLine(triangleArea);
        }

        static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
