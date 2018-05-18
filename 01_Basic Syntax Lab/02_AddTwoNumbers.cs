using System;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int seconeNumber = int.Parse(Console.ReadLine());
            int sum = firstNumber + seconeNumber;

            Console.WriteLine($"{firstNumber} + {seconeNumber} = {sum}");

        }
    }
}
