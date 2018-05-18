using System;

namespace _03_MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());

            double mile = 1.60934;
            double result = km * mile;

            Console.WriteLine($"{result:F2}");

        }
    }
}
