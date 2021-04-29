using System;

namespace _01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Generate")
                {
                    break;
                }

                string[] parts = line
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];

                if (command == "Contains")
                {
                    string substring = parts[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string caseType = parts[1].ToLower();
                    int start = int.Parse(parts[2]);
                    int end = int.Parse(parts[3]);

                    string substring = activationKey.Substring(start, end - start);

                    if (caseType == "upper")
                    {
                        activationKey = activationKey.Replace(substring, substring.ToUpper());
                    }
                    else
                    {
                        activationKey = activationKey.Replace(substring, substring.ToLower());
                    }

                    Console.WriteLine(activationKey);
                }
                else
                {
                    int start = int.Parse(parts[1]);
                    int end = int.Parse(parts[2]);

                    string substring = activationKey.Substring(start, end - start);

                    activationKey = activationKey.Replace(substring, "");

                    Console.WriteLine(activationKey);
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
