using System;
using System.Linq;

namespace _06_ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();

            // Can use Array.Reverse(); for shorter syntax
            for (int i = 0; i < array.Length / 2; i++)
            {
                string temporary = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temporary;
            }

            Console.WriteLine(String.Join(" ", array));
        }
    }
}
