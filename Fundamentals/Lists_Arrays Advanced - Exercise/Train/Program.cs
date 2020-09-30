using System;
using System.Linq;
using System.Collections.Generic;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            int maxCapacity = int.Parse(Console.ReadLine());
            string[] inputArr = Console.ReadLine().Split().ToArray();

            while (inputArr[0] != "end")
            {
                if (inputArr[0] == "Add")
                {
                    int inputNum = int.Parse(inputArr[1]);
                    wagons.Add(inputNum);
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int passangers = int.Parse(inputArr[0]);

                        if ((wagons[i] + passangers) <= maxCapacity)
                        {
                            wagons[i] = wagons[i] + passangers;
                            break;
                        }
                    }
                }

                inputArr = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
