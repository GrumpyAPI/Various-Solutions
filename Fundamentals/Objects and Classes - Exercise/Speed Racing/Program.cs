using System;
using System.Collections.Generic;

namespace Speed_Racing
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

                Car car = new Car(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2]));

                cars.Add(car);
            }

            string input = "";

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                string model = tokens[1];
                int distance = int.Parse(tokens[2]);

                foreach (var car in cars)
                {
                    if (car.Model == model)
                    {
                        car.Drive(distance);
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:F2} {car.TravelDistance}");
            }
        }
    }
}
