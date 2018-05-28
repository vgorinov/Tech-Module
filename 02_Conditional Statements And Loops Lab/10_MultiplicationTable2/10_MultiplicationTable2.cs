using System;

namespace _10_MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (secondNum > 10)
            {
                int sum2 = firstNum * secondNum;
                Console.WriteLine($"{firstNum} X {secondNum} = {sum2}");
            }

            for (int i = secondNum; i <= 10; i++)
            {

                int sum = firstNum * i;
                Console.WriteLine($"{firstNum} X {i} = {sum}");
            }
        }
    }
}
