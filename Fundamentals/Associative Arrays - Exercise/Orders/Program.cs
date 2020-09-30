using System;
using System.Linq;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = new Dictionary<string, Drink>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "buy")
                {
                    break;
                }

                string product = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!orders.ContainsKey(product))
                {
                    orders[product] = new Drink();
                    orders[product].Price = price;
                    orders[product].Quantity = quantity;
                }
                else
                {
                    orders[product].Quantity += quantity;
                }

                if (orders[product].Price != price)
                {
                    orders[product].Price = price;
                }
            }

            foreach (var product in orders)
            {
                double total = product.Value.Price * product.Value.Quantity;

                Console.WriteLine($"{product.Key} -> {total:F2}");
            }
        }
    }
}
