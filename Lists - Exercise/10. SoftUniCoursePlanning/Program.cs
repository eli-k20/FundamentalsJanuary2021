using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sheduleList = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "course start")
                {
                    break;
                }

                string[] parts = line.Split(':');

                string command = parts[0];
                string lessonTitle = parts[1];

                if (command == "Add")
                {
                    if (!sheduleList.Contains(lessonTitle))
                    {
                        sheduleList.Add(lessonTitle);
                    }
                }

                else if (command == "Insert")
                {
                    int index = int.Parse(parts[2]);

                    if (index < 0 || index >= sheduleList.Count)
                    {
                        continue;
                    }
                    else if (!sheduleList.Contains(lessonTitle))
                    {
                        sheduleList.Insert(index, lessonTitle);
                    }
                }

                else if (command == "Remove")
                {
                    if (sheduleList.Contains(lessonTitle))
                    {
                        sheduleList.Remove(lessonTitle);
                    }
                    else if (sheduleList.Contains(lessonTitle + "-Exercise"))
                    {
                        sheduleList.Remove(lessonTitle + "-Exercise");
                    }
                }

                else if (command == "Swap")
                {
                    string firstLesson = parts[1];
                    string secondLesson = parts[2];

                    int index1 = sheduleList.IndexOf(firstLesson);
                    int index2 = sheduleList.IndexOf(secondLesson);

                    if (sheduleList.Contains(firstLesson) && sheduleList.Contains(secondLesson))
                    {
                        string swapped = sheduleList.ElementAt(index1);
                        sheduleList[index1] = sheduleList[index2];
                        sheduleList[index2] = swapped;
                    }

                    if (sheduleList.Contains(firstLesson + "-Exercise") && sheduleList.Contains(sheduleList[index1]))
                    {
                        index1 = sheduleList.IndexOf(firstLesson);
                        sheduleList.Remove(firstLesson + "-Exercise");
                        sheduleList.Insert(index1 + 1, firstLesson + "-Exercise");
                    }
                    else if (sheduleList.Contains(secondLesson + "-Exercise") && sheduleList.Contains(sheduleList[index2]))
                    {
                        index2 = sheduleList.IndexOf(secondLesson);
                        sheduleList.Remove(secondLesson + "-Exercise");
                        sheduleList.Insert(index2 + 1, secondLesson + "-Exercise");
                    }
                }

                else if (command == "Exercise")
                {
                    if (sheduleList.Contains(lessonTitle) && !sheduleList.Contains(lessonTitle + "-Exercise"))
                    {
                        int index = sheduleList.IndexOf(lessonTitle);
                        sheduleList.Insert(index + 1, lessonTitle + "-Exercise");
                    }
                    else if (!sheduleList.Contains(lessonTitle))
                    {
                        sheduleList.Add(lessonTitle);
                        sheduleList.Add(lessonTitle + "-Exercise");
                    }
                }
            }

            int counter = 1;
            for (int i = 0; i < sheduleList.Count; i++)
            {
                Console.WriteLine($"{counter++}.{sheduleList[i]}");
            }
        }
    }
}
