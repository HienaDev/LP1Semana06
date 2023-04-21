using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user how many Foes to create and save that value
            Console.WriteLine("How many foes would you like to create?");
            int numberOfFoes = int.Parse(Console.ReadLine());

            // Create array of foes with the size asked previously
            Foe[] foes = new Foe[numberOfFoes];

            // Request the name of each foe
            for (int i = 0; i < numberOfFoes; i++)
            {
                Console.WriteLine($"What's the name of Foe nº {i + 1}");
                string name = (Console.ReadLine());

                foes[i] = new Foe(name);
            }

            // Print name of every foe
            foreach (Foe enemy in foes)
            {
                Console.WriteLine(enemy.GetName());
            }
        }
    }
}
