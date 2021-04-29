using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class CarInfo
    {
        public int Mileage { get; set; }

        public int Fuel { get; set; }
    }
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, CarInfo> cars = new Dictionary<string, CarInfo>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split('|');

                cars.Add(parts[0], new CarInfo { Mileage = int.Parse(parts[1]), Fuel = int.Parse(parts[2]) });
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Stop")
                {
                    break;
                }

                string[] tokens = line
                    .Split(" : ");

                string command = tokens[0];

                if (command == "Drive")
                {
                    string car = tokens[1];
                    int distance = int.Parse(tokens[2]);
                    int fuel = int.Parse(tokens[3]);

                    if (fuel > cars[car].Fuel)
                    {
                        Console.WriteLine($"Not enough fuel to make that ride");
                        continue;
                    }
                    else
                    {
                        cars[car].Mileage += distance;
                        cars[car].Fuel -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }

                    if (cars[car].Mileage >= 100000)
                    {
                        cars.Remove(car);
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                }
                else if (command == "Refuel")
                {
                    string car = tokens[1];
                    int fuel = int.Parse(tokens[2]);

                    cars[car].Fuel += fuel;

                    int reminder = 0;

                    if (cars[car].Fuel > 75)
                    {
                        reminder = cars[car].Fuel - 75;
                        cars[car].Fuel = 75;
                    }

                    Console.WriteLine($"{car} refueled with {fuel - reminder} liters");
                }
                else
                {
                    string car = tokens[1];
                    int kilometers = int.Parse(tokens[2]);

                    cars[car].Mileage -= kilometers;

                    if (cars[car].Mileage < 10000)
                    {
                        cars[car].Mileage = 10000;
                        continue;
                    }

                    Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                }
            }

            cars = cars
                .OrderByDescending(x => x.Value.Mileage)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in cars)
            {
                Console.WriteLine($"{kvp.Key} -> Mileage: {kvp.Value.Mileage} kms, Fuel in the tank: {kvp.Value.Fuel} lt.");
            }
        }
    }
}
