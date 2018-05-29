using System;

namespace _02_MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = GetMax(a, b);

            if (c > result)
            {
                Console.WriteLine(c);
            }
            else 
            {
                Console.WriteLine(result);
            }
        }


        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
