using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            var userPlateNumber = new Dictionary<string, string>();

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();

                string command = commandArgs[0];
                string name = commandArgs[1];

                if (command == "register")
                {
                    string plateNumber = commandArgs[2];

                    if (!userPlateNumber.ContainsKey(name))
                    {
                        userPlateNumber[name] = plateNumber;

                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }
                else
                {
                    if (!userPlateNumber.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: usen {name} not found");
                    }
                    else
                    {
                        userPlateNumber.Remove(name);

                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, userPlateNumber.Select(x => $"{x.Key} => {x.Value}")));

            // Alt output from a template:
            //string output = "{0} => {1}";
            //Console.WriteLine(string.Join(Environment.NewLine, userPlateNumber.Select(x => string.Format(output, x.Key, x.Value))));
        }
    }
}
