using System;
using System.Linq;

namespace _02_RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] tempArray = new int[array.Length - 1];
            int[] newArray = new int[array.Length];
            int[] sum = new int[array.Length];

            for (int rotate = 0; rotate < rotations; rotate++)
            {
                for (int i = 0; i < tempArray.Length; i++)
                    tempArray[i] = array[i];

                newArray[0] = array[array.Length - 1];

                for (int i = 0; i < tempArray.Length; i++)
                    newArray[i + 1] = tempArray[i];

                array = newArray;

                for (int i = 0; i < array.Length; i++)
                    sum[i] += newArray[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
