using System;
using System.Collections.Generic;

namespace Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int numOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCars; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string model = tokens[0];
                int engineSpeed = int.Parse(tokens[1]);
                int enginePower = int.Parse(tokens[2]);
                int cargoWeight = int.Parse(tokens[3]);
                string cargoType = tokens[4];

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            foreach (var car in cars)
            {
                if (command == "fragile")
                {
                    if (car.Cargo.CargoWeight < 1000 && car.Cargo.CargoType == "fragile")
                    {
                        Console.WriteLine(car.Model);
                    }
                }
                else
                {
                    if (car.Cargo.CargoType == "flamable" && car.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
