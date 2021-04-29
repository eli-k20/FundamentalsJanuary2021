using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string line = Console.ReadLine();
                StringBuilder decrypted = new StringBuilder();

                if (line == "find")
                {
                    break;
                }

                string currentText = line;

                for (int i = 0; i < keys.Length; i++)
                {
                    for (int j = 0; j < currentText.Length; j++)
                    {
                        if (i > keys.Length - 1)
                        {
                            i = 0;
                        }

                        int looper = keys[i];

                        int newChar = currentText[j] - looper;

                        decrypted.Append((char)newChar);

                        i++;
                    }
                }

                Regex treasureRegex = new Regex(@"&(?<treasure>[A-za-z]+)&");
                Regex coordinatesRegex = new Regex(@"<(?<coordinates>[A-za-z0-9]+)>");

                Match treasureMatch = treasureRegex.Match(decrypted.ToString());
                Match coordinatesMatch = coordinatesRegex.Match(decrypted.ToString());

                if (treasureMatch.Success && coordinatesMatch.Success)
                {
                    string treasure = treasureMatch.Groups["treasure"].Value;
                    string coordinates = coordinatesMatch.Groups["coordinates"].Value;

                    Console.WriteLine($"Found {treasure} at {coordinates}");
                }
            }
        }
    }
}