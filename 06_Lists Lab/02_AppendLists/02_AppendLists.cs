using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').ToArray();
            List<string> result = new List<string>();
            Array.Reverse(input);

            foreach (var token in input)
            {
                string[] numbers = token.Split(' ');

                foreach (var item in numbers)
                {
                    if (item != " ")
                    {
                        result.Add(item);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
