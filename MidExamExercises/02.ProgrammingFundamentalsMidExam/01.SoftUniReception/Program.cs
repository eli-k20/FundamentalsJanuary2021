using System;

namespace _01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCount = int.Parse(Console.ReadLine());
            int secondCount = int.Parse(Console.ReadLine());
            int thirdCount = int.Parse(Console.ReadLine());

            int studentsWaiting = int.Parse(Console.ReadLine());

            int studentsPerHour = firstCount + secondCount + thirdCount;

            int hoursNeeded = 0;

            while (studentsWaiting > 0)
            {
                int totalHours = studentsWaiting / studentsPerHour;

                studentsWaiting -= studentsPerHour;
                hoursNeeded++;

                if (hoursNeeded % 4 == 0)
                {
                    hoursNeeded++;
                }
            }


            Console.WriteLine($"Time needed: {hoursNeeded}h.");
        }
    }
}
