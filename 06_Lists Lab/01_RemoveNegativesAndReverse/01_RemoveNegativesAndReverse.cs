using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();


            List<int> result = new List<int>();

            foreach (int num in numbers)
            {
                if (num > 0)
                {
                    result.Add(num);
                }
            }

            numbers.Clear();
            //Can use -> result.Reverse(); instead of for loop
            for (int i = result.Count - 1; i >= 0; i--)
            {
                numbers.Add(result[i]);
            }

            if (numbers.Count > 0)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
            
        }
    }
}
