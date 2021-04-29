using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentsByPoints = new Dictionary<string, int>();

            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "exam finished")
                {
                    break;
                }

                string[] parts = line.Split("-");

                string username = parts[0];

                if (parts.Length == 3)
                {
                    string language = parts[1];
                    int points = int.Parse(parts[2]);

                    if (!studentsByPoints.ContainsKey(username))
                    {
                        studentsByPoints.Add(username, points);
                    }
                    else if (studentsByPoints[username] < points)
                    {
                        studentsByPoints[username] = points;
                    }

                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 1);
                    }
                    else
                    {
                        submissions[language]++;
                    }
                }

                else
                {
                    if (studentsByPoints.ContainsKey(username))
                    {
                        studentsByPoints.Remove(username);
                    }
                }
            }

            Dictionary<string, int> sorted = studentsByPoints
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");

            foreach (var pair in sorted)
            {
                Console.WriteLine($"{pair.Key} | {pair.Value}");
            }

            Dictionary<string, int> languages = submissions
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Submissions:");

            foreach (var pair in languages)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

        }
    }
}
