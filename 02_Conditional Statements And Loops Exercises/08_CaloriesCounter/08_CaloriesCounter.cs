using System;

namespace _08_CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            double calories = 0;

            for (int i = 0; i < numberOfProducts; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    calories += 500;
                }
                else if (ingredient == "tomato sauce")
                {
                    calories += 150;
                }
                else if (ingredient == "salami")
                {
                    calories += 600;
                }
                else if (ingredient == "pepper")
                {
                    calories += 50;
                }
            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
