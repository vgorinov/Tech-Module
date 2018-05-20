using System;

namespace _14_MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            string thirdLetter = Console.ReadLine();

            string result = "";

            for (char d1 = firstLetter; d1 <= secondLetter; d1++)
            {
                for (char d2 = firstLetter; d2 <= secondLetter; d2++)
                {
                    for (char d3 = firstLetter; d3 <= secondLetter; d3++)
                    {
                        result = $"{d1}{d2}{d3} ";

                        if (!result.Contains(thirdLetter))
                        {
                            Console.Write(result);
                        }
                    }
                }
            }
        }
    }
}
