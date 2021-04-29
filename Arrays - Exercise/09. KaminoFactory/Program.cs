using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace _09._KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int bestLength = 1;
            int bestStartIndex = 0;
            int bestSequenceSum = 0;
            int[] bestSequence = new int[size];
            int bestSample = 1;

            int sample = 0;

            while (true)
            {
                string input = Console.ReadLine();
                sample += 1;

                if (input == "Clone them!")
                {
                    break;
                }

                int[] currentSequence = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentSequenceSum = 0;

                foreach (var item in currentSequence)
                {
                    currentSequenceSum += item;
                }

                for (int i = 0; i < currentSequence.Length; i++)
                {
                    if (currentSequence[i] == 0)
                    {
                        continue;
                    }

                    int bestCurrentLenth = 1;

                    for (int j = i + 1; j < currentSequence.Length; j++)
                    {
                        if (currentSequence[i] == currentSequence[j])
                        {
                            bestCurrentLenth += 1;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (bestCurrentLenth > bestLength)
                    {
                        bestLength = bestCurrentLenth;
                        bestStartIndex = i;
                        bestSequenceSum = currentSequenceSum;
                        bestSequence = currentSequence.ToArray();
                        bestSample = sample;
                    }

                    else if (bestCurrentLenth == bestLength)
                    {
                        if (i < bestStartIndex)
                        {
                            bestLength = bestCurrentLenth;
                            bestStartIndex = i;
                            bestSequenceSum = currentSequenceSum;
                            bestSequence = currentSequence.ToArray();
                            bestSample = sample;
                        }
                        else if (i == bestStartIndex && currentSequenceSum > bestSequenceSum)
                        {
                            bestLength = bestCurrentLenth;
                            bestStartIndex = i;
                            bestSequenceSum = currentSequenceSum;
                            bestSequence = currentSequence.ToArray();
                            bestSample = sample;

                        }
                    }
                }
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(' ', bestSequence));

        }
    }
    
}
