using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                input = FirstCharToUpper(input);

                string[] vehicleData = input.Split();

                int hp = int.Parse(vehicleData[3]);

                Vehicle vehicle = new Vehicle(vehicleData[0], vehicleData[1], vehicleData[2], hp);

                vehicles.Add(vehicle);

                input = Console.ReadLine();
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (var vehicle in vehicles)
                {
                    if (vehicle.Model == input)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}\nModel: {vehicle.Model}\nColor: {vehicle.Color}\nHorsepower: {vehicle.Horsepower}");
                    }
                }
            }

            double carsAverageHp = 0;
            double trucksAverageHp = 0;
            int carCounter = 0;
            int truckCounter = 0;

            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == "Car")
                {
                    carCounter++;
                    carsAverageHp += vehicle.Horsepower;
                }
                else
                {
                    truckCounter++;
                    trucksAverageHp += vehicle.Horsepower;
                }
            }

            carsAverageHp = carsAverageHp / carCounter;
            trucksAverageHp = trucksAverageHp / truckCounter;

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHp:F2}.\nTrucks have average horsepower of: {trucksAverageHp:F2}.");
        }

        static string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }
    }
}
