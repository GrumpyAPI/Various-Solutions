using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();
            string customer;

            while ((customer = Console.ReadLine()) != "End")
            {
                if (customer == "Paid")
                {
                    while (customers.Any())
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(customer);
                }
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
