using System;
using System.Threading.Channels;

namespace _01.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());

            int peopleWaiting = int.Parse(Console.ReadLine());

            int peoplePerHour = firstEmployee + secondEmployee + thirdEmployee;

            int timeNeeded = 0;

            while (peopleWaiting > 0)
            {
                int totalHours = peopleWaiting / peoplePerHour;

                peopleWaiting -= peoplePerHour;
                timeNeeded++;

                if (timeNeeded % 4 == 0)
                {
                    timeNeeded++;
                }
            }

            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}
