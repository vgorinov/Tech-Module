using System;

namespace _17_PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (char i = (char)first; i <= second; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
