using System;

namespace _15_FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                bool isTrue = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isTrue = false;
                        break;
                    }
                }
                if (i != 1 && i != 0)
                {
                    Console.WriteLine($"{i} -> {isTrue}");
                }
            }
        }
    }
}
