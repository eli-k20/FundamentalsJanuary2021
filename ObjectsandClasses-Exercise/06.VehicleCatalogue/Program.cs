using System;
using System.Collections.Generic;

namespace _06.VehicleCatalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] vehicleData = line.Split();

                string type = vehicleData[0];
                string model = vehicleData[1];
                string color = vehicleData[2];
                int horsepower = int.Parse(vehicleData[3]);

                Vehicle vehicle = new Vehicle()
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    Horsepower = horsepower
                };

                vehicles.Add(vehicle);
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Close the Catalogue")
                {
                    break;
                }

                Vehicle vehicle = GetVehicleByModel(vehicles, command);

                if (vehicle == null)
                {
                    continue;
                }

                if (vehicle.Type == "car")
                {
                    Console.WriteLine("Type: Car");
                }
                else
                {
                    Console.WriteLine("Type: Truck");
                }
                
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
            }

            double carsAverage = CalcAvrgHorsePowerByType(vehicles, "car"); 
            double trucksAverage = CalcAvrgHorsePowerByType(vehicles, "truck");

            Console.WriteLine($"Cars have average horsepower of: {carsAverage:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:F2}.");
        }

        private static double CalcAvrgHorsePowerByType(List<Vehicle> vehicles, string type)
        {
            int typeCount = 0;
            int typeHorsePowerTotal = 0;

            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == type)
                {
                    typeCount++;
                    typeHorsePowerTotal += vehicle.Horsepower;
                }
            }

            if (typeCount == 0)
            {
                return 0;
            }

            return (double) typeHorsePowerTotal / typeCount;
        }

        private static Vehicle GetVehicleByModel(List<Vehicle> vehicles, string model)
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Model == model)
                {
                    return vehicle;
                }   
            }

            return null;
        }
    }
}
