using System;

namespace _12_TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int count = 0;
            int sum = 0;

            for (int d1 = firstNum; d1 >= 1; d1--)
            {
                for (int d2 = 1; d2 <= secondNum; d2++)
                {
                    sum = sum + (3 * (d1 * d2));
                    count++;

                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
