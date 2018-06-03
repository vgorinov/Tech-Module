using System;

namespace _04_TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            bool tripleNums = false;

            for (int p1 = 0; p1 < numbers.Length; p1++)
            {
                for (int p2 = p1 + 1; p2 < numbers.Length; p2++)
                {
                    for (int p3 = 0; p3 < numbers.Length; p3++)
                    {
                        if (numbers[p1] + numbers[p2] == numbers[p3])
                        {
                            Console.WriteLine($"{numbers[p1]} + {numbers[p2]} == {numbers[p3]}");
                            tripleNums = true;
                            break;
                        }
                    }
                }
            }

            if (!tripleNums)
            {
                Console.WriteLine("No");
            }
        }
    }
}
