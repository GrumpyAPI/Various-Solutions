using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            while (input[0] != "End")
            {
                if (input[0] == "Add")
                {
                    AddNumberToList(input, numbers);
                }
                else if (input[0] == "Insert")
                {
                    InsertNumberAtIndex(input, numbers);
                }
                else if (input[0] == "Remove")
                {
                    RemoveAtIndex(input, numbers);
                }
                else if (input[0] == "Shift")
                {
                    ShiftLeftRight(input, numbers);
                }

                input = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void AddNumberToList(List<string> input, List<int> numbers)
        {
            int number = int.Parse(input[1]);
            numbers.Add(number);
        }

        static void InsertNumberAtIndex(List<string> input, List<int> numbers)
        {
            int number = int.Parse(input[1]);
            int index = int.Parse(input[2]);

            if (index >= numbers.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.Insert(index, number);
            }
        }

        static void RemoveAtIndex(List<string> input, List<int> numbers)
        {
            int index = int.Parse(input[1]);

            if (index >= numbers.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.RemoveAt(index);
            }
        }

        static void ShiftLeftRight(List<string> input, List<int> numbers)
        {
            int count = int.Parse(input[2]);

            if (input[1] == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Add(numbers[0]);
                    numbers.RemoveAt(0);
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
        }
    }
}
