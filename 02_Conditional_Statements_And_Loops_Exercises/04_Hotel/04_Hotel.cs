using System;

namespace _04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());

            double studioPricePerNight = 0;
            double doublePricePerNight = 0;
            double suitePricePerNight = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPricePerNight = 50;
                    doublePricePerNight = 65;
                    suitePricePerNight = 75;
                    break;
                case "June":
                case "September":
                    studioPricePerNight = 60;
                    doublePricePerNight = 72;
                    suitePricePerNight = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    studioPricePerNight = 68;
                    doublePricePerNight = 77;
                    suitePricePerNight = 89;
                    break;
            }


            if ((month == "May" || month == "October") && nights > 7)
            {
                studioPricePerNight *= 0.95;
            }
            else if ((month == "June" || month == "September") && nights > 14)
            {
                doublePricePerNight *= 0.9;
            }
            else if ((month == "July" || month == "August" || month == "December") && nights > 14)
            {
                suitePricePerNight *= 0.85;
            }

            double totalStudioPrice = studioPricePerNight * nights;
            double totalDoublePrice = doublePricePerNight * nights;
            double totalSuitePrice = suitePricePerNight * nights;

            if ((month == "September" || month == "October") && nights > 7)
            {
                totalStudioPrice -= studioPricePerNight;
            }

            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:F2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:F2} lv.");
        }
    }
}
