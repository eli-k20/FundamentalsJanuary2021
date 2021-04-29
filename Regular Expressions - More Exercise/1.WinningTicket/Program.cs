using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tickets = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < tickets.Count; i++)
            {
                string currentTicket = tickets[i].Trim();

                if (currentTicket.Length == 20)
                {
                    Regex winningSymbols = new Regex(@"(\@{6,}|\${6,}|\^{6,}|\#{6,})");

                    Match leftMatch = winningSymbols.Match(currentTicket.Substring(0, 10));
                    Match rightMatch = winningSymbols.Match(currentTicket.Substring(10));

                    int minLength = Math.Min(leftMatch.Length, rightMatch.Length);

                    if (!leftMatch.Success || !rightMatch.Success)
                    {
                        result.AppendLine($"ticket \"{currentTicket}\" - no match");
                        continue;
                    }

                    string leftPart = leftMatch.Value.Substring(0, minLength);
                    string rightPart = rightMatch.Value.Substring(0, minLength);

                    if (leftPart.Equals(rightPart))
                    {
                        if (leftPart.Length == 10)
                        {
                            result.AppendLine($"ticket \"{currentTicket}\" - {minLength}{leftPart.Substring(0, 1)} Jackpot!");
                        }
                        else
                        {
                            result.AppendLine($"ticket \"{currentTicket}\" - {minLength}{leftPart.Substring(0, 1)}");
                        }
                    }

                }
                else
                {
                    result.AppendLine("invalid ticket");
                }
            }

            Console.Write(result.ToString());
        }
    }
}

