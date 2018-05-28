using System;

namespace _13_VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == 'a' || symbol == 'o' || symbol == 'u' || symbol == 'e' || symbol == 'i')
            {
                Console.WriteLine("vowel");
            } else if (symbol >= 48 && symbol <= 57) {
                Console.WriteLine("digit");
            } else
            {
                Console.WriteLine("other");
            }
        }
    }
}
