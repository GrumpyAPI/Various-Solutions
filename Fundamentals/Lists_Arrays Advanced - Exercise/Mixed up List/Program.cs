using System;
using System.Linq;
using System.Collections.Generic;

namespace Mixed_up_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            secondList.Reverse();

            List<int> mixedList = new List<int>();

            int count = 0;

            if (firstList.Count > secondList.Count)
            {
                count = secondList.Count;
            }
            else
            {
                count = firstList.Count;
            }

            for (int i = 0; i < count; i++)
            {
                mixedList.Add(firstList[i]);
                mixedList.Add(secondList[i]);
            }

            count = Math.Abs(firstList.Count - secondList.Count);

            List<int> range = new List<int>();

            for (int i = 0; i < count; i++)
            {
                if (firstList.Count > secondList.Count)
                {
                    range.Add(firstList[(firstList.Count - 1) - i]);
                }
                else
                {
                    range.Add(secondList[(secondList.Count - 1) - i]);
                }
            }

            range.Sort();

            List<int> result = new List<int>();

            for (int i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i] > range[0] && mixedList[i] < range[1])
                {
                    result.Add(mixedList[i]);
                }
            }

            result.Sort();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
