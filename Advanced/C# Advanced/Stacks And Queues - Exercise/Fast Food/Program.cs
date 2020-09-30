using System;
using System.Linq;
using System.Collections.Generic;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>();

            int biggestOrder = int.MinValue;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > biggestOrder)
                {
                    biggestOrder = input[i];
                }

                orders.Enqueue(input[i]);
            }

            Console.WriteLine(biggestOrder);

            while (orders.Any())
            {
                int currentOrder = orders.Peek();

                if (currentOrder < foodQuantity)
                {
                    foodQuantity -= currentOrder;
                    orders.Dequeue();
                }
                else
                {
                    int ordersLeft = orders.Sum();

                    Console.WriteLine($"Orders left: {ordersLeft}");
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
