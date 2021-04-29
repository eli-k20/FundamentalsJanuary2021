using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            List<int> numbers = new List<int>(firstList.Count + secondList.Count);

            int limit = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < limit; i++)
            {
                numbers.Add(firstList[i]);
                numbers.Add(secondList[i]);
            }

            if (firstList.Count != secondList.Count)
            {
                if (firstList.Count > secondList.Count)
                {
                    numbers.AddRange(GetReminderList(firstList, secondList));
                }
                else
                {
                    numbers.AddRange(GetReminderList(secondList, firstList));
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<int> GetReminderList(List<int> longer, List<int> shorter)
        {
            if (longer.Count <= shorter.Count)
            {
                throw new ArgumentException();
            }

            List<int> result = new List<int>();

            for (int i = shorter.Count; i < longer.Count; i++)
            {
                result.Add(longer[i]);
            }

            return result;
        }
    }
}
