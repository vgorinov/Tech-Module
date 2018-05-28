using System;

namespace _05_CharacterStars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string finalHealth = "|" + new string('|', currentHealth) + new string('.', maxHealth - currentHealth) + "|";
            string finalEnergy = "|" + new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy) + "|";

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {finalHealth}");
            Console.WriteLine($"Energy: {finalEnergy}");
        }
    }
}
