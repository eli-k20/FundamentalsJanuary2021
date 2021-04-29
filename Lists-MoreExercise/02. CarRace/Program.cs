using System;
using System.Linq;

namespace _02. CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int finishLine = array.Length / 2;

            double firstRacerTime = 0;
            double secondRacerTime = 0;

            for (int i = 0; i < finishLine; i++)
            {
                if (array[i] == 0)
                {
                    firstRacerTime -= 0.20 * firstRacerTime;
                }

                firstRacerTime += array[i];
            }

            for (int j = array.Length - 1; j > finishLine; j--)
            {
                if (array[j] == 0)
                {
                    secondRacerTime -= 0.20 * secondRacerTime;
                }

                secondRacerTime += array[j];
            }

            if (firstRacerTime < secondRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {firstRacerTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {secondRacerTime}");
            }
        }
    }
}