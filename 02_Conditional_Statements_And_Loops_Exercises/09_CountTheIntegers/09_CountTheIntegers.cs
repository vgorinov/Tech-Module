using System;

namespace _09_CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            try
            {
                while (true)
                {
                    int number = int.Parse(Console.ReadLine());
                    count++;
                }
            }
            catch
            {
                Console.WriteLine(count);
            }
        }
    }
}
