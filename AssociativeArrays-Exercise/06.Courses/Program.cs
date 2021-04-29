using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split(" : ");

                string courseName = parts[0];
                string student = parts[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(student);
            }

            Dictionary<string, List<string>> sorted = courses
                .OrderByDescending(c => c.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in sorted)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count}");

                pair.Value.Sort();

                foreach (var student in pair.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
