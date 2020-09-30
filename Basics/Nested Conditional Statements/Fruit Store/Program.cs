using System;

namespace Fruit_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if(day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    double output = quantity * 2.50;
                    Console.WriteLine($"{output:F2}");
                }
                else if (fruit == "apple")
                {
                    double output = quantity * 1.20;
                    Console.WriteLine($"{output:F2}");
                }
                else if (fruit == "orange")
                {
                    double output = quantity * 0.85;
                    Console.WriteLine($"{output:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    double output = quantity * 1.45;
                    Console.WriteLine($"{output:F2}");
                }
                else if (fruit == "kiwi")
                {
                    double output = quantity * 2.70;
                    Console.WriteLine($"{output:F2}");
                }
                else if (fruit == "pineapple")
                {
                    double output = quantity * 5.50;
                    Console.WriteLine($"{output:F2}");
                }
                else if (fruit == "grapes")
                {
                    double output = quantity * 3.85;
                    Console.WriteLine($"{output:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    double output = quantity * 2.70;
                    Console.WriteLine($"{output:F2}");
                }
                else if (fruit == "apple")
                {
                    double output = quantity * 1.25;
                    Console.WriteLine($"{output:F2}");
                }
                else if (fruit == "orange")
                {
                    double output = quantity * 0.90;
                    Console.WriteLine($"{output:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    double output = quantity * 1.60;
                    Console.WriteLine($"{output:F2}");
                }
                else if (fruit == "kiwi")
                {
                    double output = quantity * 3.00;
                    Console.WriteLine($"{output:F2}");
                }
                else if (fruit == "pineapple")
                {
                    double output = quantity * 5.60;
                    Console.WriteLine($"{output:F2}");
                }
                else if (fruit == "grapes")
                {
                    double output = quantity * 4.20;
                    Console.WriteLine($"{output:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
