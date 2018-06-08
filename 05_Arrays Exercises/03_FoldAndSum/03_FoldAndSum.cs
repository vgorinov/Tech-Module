using System;
using System.Linq;

namespace _03_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = arr.Length / 4;

            int[] left = GetPart(arr, k, 0);
            int[] middle = GetPart(arr, k * 2, k);
            int[] right = GetPart(arr, k, k * 3);

            Array.Reverse(left);
            Array.Reverse(right);

            int[] merged = new int[k * 2];

            int index = 0;
            for (int i = 0; i < k; i++)
            {
                merged[index++] = left[i];
            }

            for (int i = 0; i < k; i++)
            {
                merged[index++] = right[i];
            }

            for (int i = 0; i < middle.Length; i++)
            {
                int sum = middle[i] + merged[i];
                Console.Write($"{sum} ");
            }
            Console.WriteLine();

        }

        private static int[] GetPart(int[] arr, int size, int startIndex)
        {
            int[] part = new int[size];
            int index = 0;
            for (int i = startIndex; i < size + startIndex; i++)
            {
                part[i - startIndex] = arr[i];
            }

            return part;
        }
    }
}
