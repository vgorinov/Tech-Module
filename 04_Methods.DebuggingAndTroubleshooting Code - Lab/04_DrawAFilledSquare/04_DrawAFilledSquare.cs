using System;

namespace _04_DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintDashes(n);
            PrintBody(n);
            PrintDashes(n);
        }


        static void PrintDashes(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void PrintBody(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");

                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine("-");
            }
        }
    }
}

