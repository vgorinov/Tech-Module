using System;

namespace _08_GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int result = GetMax(first, second);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char result = GetMax(first, second);
                Console.WriteLine(result);
            }
            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string result = GetMax(first, second);
                Console.WriteLine(result);
            }
        }


        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
