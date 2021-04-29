using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            string destinations = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Travel")
                {
                    break;
                }

                string[] parts = line
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];

                if (command == "Add Stop")
                {
                    int index = int.Parse(parts[1]);
                    string info = parts[2];

                    if (index >= 0 && index < destinations.Length)
                    {
                        destinations = destinations.Insert(index, info);
                    }

                }

                else if (command == "Remove Stop")
                {
                    int start = int.Parse(parts[1]);
                    int end = int.Parse(parts[2]);
                    if (end < start)
                    {
                        continue;
                    }
                    if (start >= 0 && start < destinations.Length && end >= 0 && end < destinations.Length)
                    {
                        destinations = destinations.Remove(start, end - start + 1);
                    }

                }

                else if (command == "Switch")
                {
                    string oldString = parts[1];
                    string newString = parts[2];

                    if (destinations.Contains(oldString) && oldString != newString)
                    {

                        destinations = destinations.Replace(oldString, newString);

                    }

                }


                Console.WriteLine(destinations);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }
    }
}
