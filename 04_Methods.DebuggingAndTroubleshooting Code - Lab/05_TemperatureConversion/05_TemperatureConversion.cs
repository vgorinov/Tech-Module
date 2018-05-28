using System;

namespace _05_TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celcius = FahreinheitToCelcius(fahrenheit);

            Console.WriteLine($"{celcius:F2}");
        }


        static double FahreinheitToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
