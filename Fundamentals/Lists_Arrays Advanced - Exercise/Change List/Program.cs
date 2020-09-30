using System;
using System.Linq;
using System.Collections.Generic;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<string> commands = Console.ReadLine()
                .Split()
                .ToList();

            while (commands[0] != "end")
            {
                if (commands[0] == "Delete")
                {
                    int num = int.Parse(commands[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers.Remove(num);
                    }
                }
                else if (commands[0] == "Insert")
                {
                    int item = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);

                    numbers.Insert(index, item);
                }

                commands = Console.ReadLine()
                .Split()
                .ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
