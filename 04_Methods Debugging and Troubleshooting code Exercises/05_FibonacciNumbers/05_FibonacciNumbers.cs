using System;

namespace _05_FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("0");
            }
            else if (number == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine(GetFibonacciNumbers(number));
            }
        }


        static int GetFibonacciNumbers(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }
    }
}
