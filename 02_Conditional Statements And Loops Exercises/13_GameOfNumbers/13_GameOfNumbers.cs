using System;

namespace _13_GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int count = 0;
            int num = 0;
            string result = "";
            bool isFound = false;

            for (int d1 = firstNum; d1 <= secondNum; d1++)
            {
                for (int d2 = firstNum; d2 <= secondNum; d2++)
                {
                    count++;
                    if (d1 + d2 == magicalNumber)
                    {
                        isFound = true;
                        num = d1 + d2;
                        result = $"{d1} + {d2} = {magicalNumber}";
                    }
                }
            }

            if (isFound == false)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicalNumber}");
                return;
            }

            Console.WriteLine($"Number found! {result}");

        }
    }
}
