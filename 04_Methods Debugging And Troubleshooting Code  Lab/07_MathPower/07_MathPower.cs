using System;

namespace _07_MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            long power = long.Parse(Console.ReadLine());

            double finalNumber = RaiseToPower(number, power);

            Console.WriteLine(finalNumber);
        }

        static double RaiseToPower(double number, long power)
        {
            return Math.Pow(number, power);
        }
    }
}
