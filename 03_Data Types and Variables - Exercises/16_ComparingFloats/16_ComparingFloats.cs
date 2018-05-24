using System;

namespace _16_ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            double difference = Math.Max(num1, num2) - Math.Min(num1, num2);

            if (difference > eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

        }
    }
}
