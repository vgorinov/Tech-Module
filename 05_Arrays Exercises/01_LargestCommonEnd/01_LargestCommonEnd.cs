using System;
using System.Linq;

namespace _01_LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();
            string[] secondArray = Console.ReadLine().Split().ToArray();

            var shorterArray = Math.Min(firstArray.Length, secondArray.Length);
            var longerArray = Math.Max(firstArray.Length, secondArray.Length);

            int countLeft = 0;
            int countRight = 0;
            
            for (int i = 0; i < shorterArray; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    countLeft++;
                }

                if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
                {
                    countRight++;
                }
            }

            int countTotal = Math.Max(countLeft, countRight);
            Console.WriteLine(countTotal);
        }
    }
}
