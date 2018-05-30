using System;

namespace _04_NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();

            ReverseNumbers(numberString);
        }

        static void ReverseNumbers(string numStr)
        {
            string result = "";
            char symbol = '\0';
            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                symbol = numStr[i];
                result += symbol;
            }

            Console.WriteLine(result);
        }
    }
}
