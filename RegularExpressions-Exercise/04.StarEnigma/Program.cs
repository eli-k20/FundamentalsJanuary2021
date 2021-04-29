using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regexKey = new Regex(@"[STARstar]");
            Regex pattern = new Regex(@"^[^@\-!:>]*@(?<name>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<type>[A|D])![^@\-!:>]*->[^@\-!:>]*(?<soldiers>\d+)[^@\-!:>]*$");

            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                int key = regexKey.Matches(text).Count;

                string decryptedText = DecryptText(text, key);

                Match match = pattern.Match(decryptedText);

                if (!match.Success)
                {
                    continue;
                }

                string name = match.Groups["name"].Value;
                string type = match.Groups["type"].Value;

                if (type == "A")
                {
                    attacked.Add(name);
                }
                else
                {
                    destroyed.Add(name);
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            
            foreach (var planet in attacked.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var planet in destroyed.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        private static string DecryptText(string text, int key)
        {
            StringBuilder decrypted = new StringBuilder();

            foreach (var letter in text)
            {
                decrypted.Append((char) (letter - key));
            }

            return decrypted.ToString();
        }
    }
}
