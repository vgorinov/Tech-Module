using System;

namespace _06_PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            if (n == 0 || n == 1)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine(IsPrime(n));
            }
        }

        static bool IsPrime(long n)
        {
            bool isValid = true;
            int counter = 2;

            while (counter <= Math.Sqrt(n))
            {
                if (n % counter == 0)
                {
                    isValid = false;
                    break;
                }
                counter++;
            }
            return isValid;
        }
    }
}
