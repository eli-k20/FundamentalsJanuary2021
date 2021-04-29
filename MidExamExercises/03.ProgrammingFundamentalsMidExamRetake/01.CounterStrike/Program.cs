using System;
using System.ComponentModel.Design;

namespace _01.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int wins = 0;

            while (energy >= 0)
            {
                string input = Console.ReadLine();

                if (input == "End of battle")
                {
                    break;
                }

                else
                {
                    int currentDistance = int.Parse(input);

                    if (currentDistance > energy)
                    {
                        Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    }

                    energy -= currentDistance;
                    wins++;

                    if (wins % 3 == 0)
                    {
                        energy += wins;
                    }
                }

            }

            if (energy >= 0)
            { 
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
        }
    }
}
