using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._MixedUpLists
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

            List<int> newList = new List<int>();
            List<int> maxList = new List<int>();

            List<int> range = new List<int>();

            if (firstList.Count > secondList.Count)
            {
                maxList = firstList;
            }

            else
            {
                maxList = secondList;
                maxList.Reverse();
            }

            for (int i = maxList.Count - 2; i < maxList.Count; i++)
            {
                range.Add(maxList[i]);
            }
            range.Sort();

            if (firstList.Count > secondList.Count)
            {
                firstList.RemoveRange(firstList.Count - 2, 2);
                secondList.Reverse();
            }

            else
            {
                secondList.RemoveRange(secondList.Count - 2, 2);
                secondList.Reverse();
            }


            for (int i = 0; i < firstList.Count; i++)
            {
                newList.Add(firstList[i]);
                newList.Add(secondList[i]);
            }

            newList.Sort();

            Console.WriteLine(string.Join(" ", newList.Where(n => n > range[0] && n < range[1])));
        }
    }
}
