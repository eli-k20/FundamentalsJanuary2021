using System;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int initialBitCoins = 0;

            string[] rooms = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            int bestRoom = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] currentRoom = rooms[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (initialHealth < 0)
                {
                    break;
                }

                string command = currentRoom[0];
                int number = int.Parse(currentRoom[1]);

                if (command == "potion")
                {
                    int currentHealth = initialHealth + number;

                    if (currentHealth > 100)
                    {
                        currentHealth = 100;
                        number = 100 - initialHealth;
                    }

                    initialHealth = currentHealth;
                    Console.WriteLine($"You healed for {number} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }

                else if (command == "chest")
                {
                    initialBitCoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }

                else
                {
                    initialHealth -= number;

                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                }
            }

            if (initialHealth > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {initialBitCoins}");
                Console.WriteLine($"Health: {initialHealth}");
            }
        }
    }
}
