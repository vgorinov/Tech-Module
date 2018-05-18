using System;

namespace _06_IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = Math.Min(firstNum, secondNum); i <= Math.Max(secondNum, firstNum); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
