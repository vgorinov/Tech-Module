using System;

namespace _02_ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;


            if (profession == "Athlete")
            {
                price = 0.70;
                Console.WriteLine($"The {profession} has to pay {price * quantity:F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = 1.00;
                Console.WriteLine($"The {profession} has to pay {price * quantity:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                price = 1.70;
                Console.WriteLine($"The {profession} has to pay {price * quantity:F2}.");
            }
            else
            {
                price = 1.20;
                Console.WriteLine($"The {profession} has to pay {price * quantity:F2}.");


            }
        }
    }
}
