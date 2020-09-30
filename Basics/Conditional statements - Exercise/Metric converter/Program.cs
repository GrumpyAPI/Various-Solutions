using System;

namespace Metric_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            string entryMetric = Console.ReadLine();
            string exitMetric = Console.ReadLine();

            if (entryMetric == "mm" && exitMetric == "cm")
            {
                Console.WriteLine($"{amount / 10:F3}");
            }

            else if (entryMetric == "cm" && exitMetric == "mm")
            {
                Console.WriteLine($"{amount * 10:F3}");
            }

            else if (entryMetric == "cm" && exitMetric == "m")
            {
                Console.WriteLine($"{amount / 100:F3}");
            }

            else if (entryMetric == "mm" && exitMetric == "m")
            {
                Console.WriteLine($"{amount / 1000:F3}");
            }

            else if (entryMetric == "m" && exitMetric == "mm")
            {
                Console.WriteLine($"{amount * 1000:F3}");
            }

            else if (entryMetric == "m" && exitMetric == "cm")
            {
                Console.WriteLine($"{amount * 100:F3}");
            }

        }
    }
}
