using System;

namespace _04_BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());
            
            double energyKcal = energy * (volume / 100);
            double sugarKcal = sugar * (volume / 100);

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyKcal}kcal, {sugarKcal}g sugars");
        }
    }
}
