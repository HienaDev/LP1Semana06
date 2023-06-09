﻿using System;

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

            // Gets amount of powerups used and prints it
            int powerUpUsed = Foe.GetPowerUpsUsed();
            Console.WriteLine(powerUpUsed);

            // Changes health of every foe
            foes[0].PickupPowerUp(PowerUp.Health, 0);
            foes[1].PickupPowerUp(PowerUp.Health, 1);
            foes[2].PickupPowerUp(PowerUp.Health, 2);
            foes[3].PickupPowerUp(PowerUp.Health, 3);

            // Gets amount of powerups used and prints it
            powerUpUsed = Foe.GetPowerUpsUsed();
            Console.WriteLine(powerUpUsed);

            // Changes shield of every foe
            foes[0].PickupPowerUp(PowerUp.Shield, 0);
            foes[1].PickupPowerUp(PowerUp.Shield, 1);
            foes[2].PickupPowerUp(PowerUp.Shield, 2);
            foes[3].PickupPowerUp(PowerUp.Shield, 3);

            // Gets amount of powerups used and prints it
            powerUpUsed = Foe.GetPowerUpsUsed();
            Console.WriteLine(powerUpUsed);

            Console.WriteLine();

            // Print name health and shield of every foe
            foreach (Foe enemy in foes)
            {
                
                Console.WriteLine(enemy.GetName());
                Console.WriteLine(enemy.GetHealth());
                Console.WriteLine(enemy.GetShield());
                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using this program!");
        }
    }
}
