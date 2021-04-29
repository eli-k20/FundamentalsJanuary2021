﻿using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, pattern);

            foreach (Match name in matchedNames)
            {
                Console.Write($"{name} ");
            }

            Console.WriteLine();
        }
    }
}
