using System;
using System.Linq;
using System.Collections.Generic;

namespace Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            Queue<string> carsForService = new Queue<string>();
            List<string> servicedCars = new List<string>();

            for (int i = 0; i < cars.Length; i++)
            {
                carsForService.Enqueue(cars[i]);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Service")
                {
                    Console.WriteLine($"Vehicle {carsForService.Peek()} got served.");

                    servicedCars.Insert(0, carsForService.Dequeue());
                }
                else if (command.Contains("CarInfo"))
                {
                    string[] tokens = command.Split('-');
                    string carToCheck = tokens[1];

                    if (servicedCars.Contains(carToCheck))
                    {
                        Console.WriteLine("Served.");
                    }
                    else if (carsForService.Contains(carToCheck))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }
                else if (command == "History")
                {
                    Console.WriteLine(string.Join(", ", servicedCars));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Vehicles for service: {string.Join(", ", carsForService)}");

            Console.WriteLine($"Served vehicles: {string.Join(", ",servicedCars)}");
        }
    }
}
