using System;

namespace _11_5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (secondNum - firstNum < 5)
            {
                Console.WriteLine("No");
            }

            for (int d1 = firstNum; d1 <= secondNum; d1++)
            {
                for (int d2 = firstNum; d2 <= secondNum; d2++)
                {
                    for (int d3 = firstNum; d3 <= secondNum; d3++)
                    {
                        for (int d4 = firstNum; d4 <= secondNum; d4++)
                        {
                            for (int d5 = firstNum; d5 <= secondNum; d5++)
                            {
                                if (firstNum <= d1 && d1 < d2 && d2 < d3 && d3 < d4 && d4 < d5 && d5 <= secondNum)
                                {
                                    Console.WriteLine($"{d1} {d2} {d3} {d4} {d5}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

