using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split("/");

                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                string hpOrKg = tokens[3];

                if (type == "Car")
                {
                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = hpOrKg
                    };

                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = hpOrKg
                    };

                    trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            List<Car> orderedCars = cars.OrderByDescending(x => x.Brand).ToList();
            List<Truck> orderedTrucks = trucks.OrderByDescending(x => x.Brand).ToList();
            orderedCars.Reverse();
            orderedTrucks.Reverse();        // Did not manage to find how to "OrderByAscending", as it seems the default options include only descending order. ".Sort()" does not seem to work for objects.

            if (orderedCars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }

            foreach (Car car in orderedCars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            if (orderedTrucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }

            foreach (Truck truck in orderedTrucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
