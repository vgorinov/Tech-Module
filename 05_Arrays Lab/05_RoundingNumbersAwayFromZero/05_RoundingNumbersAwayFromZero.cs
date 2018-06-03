using System;
using System.Linq;

namespace _05_RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            foreach (double item in numbers)
            {
                int roundNumber = (int) Math.Round(item, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{item} => {roundNumber}");
            }
        }
    }
}
