using System;

namespace _03_RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupSize = double.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallName = "";
            double price = 0;


            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            else if (groupSize <= 50)
            {
                hallName = "Small Hall";
                price += 2500;
            }
            else if (groupSize <= 100)
            {
                hallName = "Terrace";
                price += 5000;
            }
            else if (groupSize <= 120)
            {
                hallName = "Great Hall";
                price += 7500;
            }


            if (package == "Normal")
            {
                price += 500;
                price *= 0.95;
            }
            else if (package == "Gold")
            {
                price += 750;
                price *= 0.9;
            }
            else if (package == "Platinum")
            {
                price += 1000;
                price *= 0.85;
            }


            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {price / groupSize:F2}$");
        }
    }
}
