using System;

namespace _01._DayofWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string [] 
            { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int day = int.Parse(Console.ReadLine());

            if (day < 1 || day > arr.Length)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(arr[day - 1]);
            }
        }
    }
}
