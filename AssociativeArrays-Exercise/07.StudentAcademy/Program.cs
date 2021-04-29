using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsByGrades = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsByGrades.ContainsKey(studentName))
                {
                    studentsByGrades.Add(studentName, new List<double>());
                }

                studentsByGrades[studentName].Add(grade);
            }

            Dictionary<string, List<double>> sorted = studentsByGrades
                .Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in sorted)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value.Average():F2}");
            }
        }
    }
}
