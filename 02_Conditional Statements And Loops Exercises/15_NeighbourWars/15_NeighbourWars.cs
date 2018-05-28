using System;

namespace _15_NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDmg = int.Parse(Console.ReadLine());
            int goshoDmg = int.Parse(Console.ReadLine());

            string goshoAttack = "Thunderous fist";
            string peshoAttack = "Roundhouse kick";

            int peshoHealth = 100;
            int goshoHealth = 100;

            int turn = 1;

            while (peshoHealth > 0 && goshoHealth > 0)
            {

                if (turn % 2 == 1)
                {
                    goshoHealth = goshoHealth - peshoDmg;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {turn}th round.");
                        return;
                    }
                    else if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {turn}th round.");
                        return;
                    }

                    Console.WriteLine($"Pesho used {peshoAttack} and reduced Gosho to {goshoHealth} health.");
                }


                else
                {
                    peshoHealth = peshoHealth - goshoDmg;

                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {turn}th round.");
                        return;
                    }

                    else if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {turn}th round.");
                        return;
                    }

                    Console.WriteLine($"Gosho used {goshoAttack} and reduced Pesho to {peshoHealth} health.");
                }


                if (turn % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }

                turn++;
            }
        }
    }
}
