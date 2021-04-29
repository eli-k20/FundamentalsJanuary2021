using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split(" -> ");

                string companyName = parts[0];
                string employeeId = parts[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }

                companies[companyName].Add(employeeId);
            }

            foreach (var pair in companies)
            {
                companies.Distinct();

                Console.WriteLine($"{pair.Key}");

                List<string> uniqueID = pair
                    .Value
                    .Distinct()
                    .ToList();

                foreach (var id in uniqueID)
                {
                    Console.WriteLine($"-- {id}");
                }
                
            }
        }
    }
}
