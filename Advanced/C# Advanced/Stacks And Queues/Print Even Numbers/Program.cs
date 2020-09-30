using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(input);

            List<int> result = new List<int>();

            while (queue.Any())
            {
                if (queue.Peek() % 2 == 0)
                {
                    result.Add(queue.Dequeue());
                }
                else
                {
                    queue.Dequeue();
                }
            }

            Console.Write(string.Join(", ", result));
        }
    }
}
