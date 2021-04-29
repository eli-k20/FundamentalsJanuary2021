using System;

namespace _01.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            double bonus = double.Parse(Console.ReadLine());

            double maxBonus = 0;
            int bestAttendance = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int attendance = int.Parse(Console.ReadLine());

                double totalBonus = (attendance / lectures) * (5 + bonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    bestAttendance = attendance;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {bestAttendance} lectures.");
        }
    }
}
