using System;

namespace _01_DaysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] dayOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday" };

            if (number < 1 || number > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }

            string dayInEnglish = dayOfWeek[number - 1];
            Console.WriteLine(dayInEnglish);
        }
    }
}
