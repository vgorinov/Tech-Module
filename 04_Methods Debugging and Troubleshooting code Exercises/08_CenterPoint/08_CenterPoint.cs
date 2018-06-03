using System;

namespace _08_CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine(GetCoordinates(x1, y1, x2, y2));
        }

        static string GetCoordinates(double x1, double y1, double x2, double y2)
        {
            double combinationOne = Math.Abs(x1) + Math.Abs(y1);
            double combinationTwo = Math.Abs(x2)+ Math.Abs(y2);

            string result = "";
            double validComb = 0;
            if (combinationOne <=combinationTwo)
            {
                result = $"({x1}, {y1})";
            }
            else
            {
                result = $"({x2}, {y2})";
            }

            return result;
        }
    }
}
