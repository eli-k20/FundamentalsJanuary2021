using System;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string text = line;
                string decrypted = String.Empty;

                for (int i = 0; i < text.Length; i++)
                {
                    int currentSymbol = text[i] - key;
                    decrypted += (char)currentSymbol;

                }

                Regex regex = new Regex(@"@(?<name>[A-Za-z]+)(?<between>.+)!(?<letter>G|N)!");

                Match nameMatch = regex.Match(decrypted);
                Match behaviourMatch = regex.Match(decrypted);
                Match betweenMatch = regex.Match(decrypted);

                if (nameMatch.Success)
                {
                    string currentName = nameMatch.Groups["name"].Value;
                    string letter = behaviourMatch.Groups["letter"].Value;
                    string between = betweenMatch.Groups["between"].Value;

                    bool valid = true;

                    for (int i = 0; i < between.Length; i++)
                    {
                        if (between[i] == '@'
                        || between[i] == '-'
                        || between[i] == '!'
                        || between[i] == ':'
                        || between[i] == '>')
                        {
                            valid = false;
                            break;
                        }
                    }

                    if (decrypted.IndexOf(currentName) < decrypted.IndexOf(letter) && valid == true)
                    {
                        if (behaviourMatch.Groups["letter"].Value.Equals("G"))
                        {
                            Console.WriteLine(currentName);
                        }
                    }

                }

            }

        }
    }
}