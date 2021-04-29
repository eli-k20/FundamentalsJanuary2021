using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());

            int[] currentState = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int maxCapacity = 4;

            int peopleOnTheCurrentWagon = 0;
            int peopleOnTheLift = 0;

            bool noMorePeople = false;

            for (int i = 0; i < currentState.Length; i++)
            {
                while (currentState[i] < maxCapacity)
                {
                    currentState[i]++;
                    peopleOnTheCurrentWagon++;

                    if (peopleOnTheCurrentWagon + peopleOnTheLift == peopleWaiting)
                    {
                        noMorePeople = true;
                        break;
                    }
                }

                peopleOnTheLift += peopleOnTheCurrentWagon;
                if (noMorePeople)
                {
                    break;
                }

                peopleOnTheCurrentWagon = 0;
            }

            if (peopleWaiting < currentState.Length * maxCapacity && currentState.Any(c => c < maxCapacity))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", currentState));
            }

            else if (peopleWaiting > peopleOnTheLift)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting - peopleOnTheLift} people in a queue!");
                Console.WriteLine(string.Join(" ", currentState));
            }

            else if (currentState.All(c => c == maxCapacity) && noMorePeople == true)
            {
                Console.WriteLine(string.Join(" ", currentState));
            }
        }

    }
}
