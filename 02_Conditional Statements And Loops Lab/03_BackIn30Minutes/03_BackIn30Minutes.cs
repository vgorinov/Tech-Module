using System;

namespace _03_BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;

            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }
            if (hours > 23)
            {
                hours = 0;

            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
