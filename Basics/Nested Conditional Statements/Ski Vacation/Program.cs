using System;

namespace Ski_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string residence = Console.ReadLine();
            string evaluation = Console.ReadLine();

            if (residence == "room for one person")
            {
                if (evaluation == "positive")
                {
                    double price = (days - 1) * 18;
                    double output = price + price * 0.25;
                    Console.WriteLine($"{output:F2}");
                }
                else
                {
                    double price = (days - 1) * 18;
                    double output = price - price * 0.10;
                    Console.WriteLine($"{output:F2}");
                }
            }
            else if (residence == "apartment")
            {
                if (days < 10)
                {
                    if (evaluation == "positive")
                    {
                        double price = (days - 1) * 25;
                        double discount = price - price * 0.30;
                        double output = discount + discount * 0.25;
                        Console.WriteLine($"{output:F2}");
                    }
                    else
                    {
                        double price = (days - 1) * 25;
                        double discount = price - price * 0.30;
                        double output = discount - discount * 0.10;
                        Console.WriteLine($"{output:F2}");
                    }
                }
                else if (days >= 10 && days <= 15)
                {
                    if (evaluation == "positive")
                    {
                        double price = (days - 1) * 25;
                        double discount = price - price * 0.35;
                        double output = discount + discount * 0.25;
                        Console.WriteLine($"{output:F2}");
                    }
                    else
                    {
                        double price = (days - 1) * 25;
                        double discount = price - price * 0.35;
                        double output = discount - discount * 0.10;
                        Console.WriteLine($"{output:F2}");
                    }
                }
                else if (days > 15)
                {
                    if (evaluation == "positive")
                    {
                        double price = (days - 1) * 25;
                        double discount = price - price * 0.50;
                        double output = discount + discount * 0.25;
                        Console.WriteLine($"{output:F2}");
                    }
                    else
                    {
                        double price = (days - 1) * 25;
                        double discount = price - price * 0.50;
                        double output = discount - discount * 0.10;
                        Console.WriteLine($"{output:F2}");
                    }
                }
            }
            if (residence == "president apartment")
            {
                if (days < 10)
                {
                    if (evaluation == "positive")
                    {
                        double price = (days - 1) * 35;
                        double discount = price - price * 0.10;
                        double output = discount + discount * 0.25;
                        Console.WriteLine($"{output:F2}");
                    }
                    else
                    {
                        double price = (days - 1) * 35;
                        double discount = price - price * 0.10;
                        double output = discount - discount * 0.10;
                        Console.WriteLine($"{output:F2}");
                    }
                }
                else if (days >= 10 && days <= 15)
                {
                    if (evaluation == "positive")
                    {
                        double price = (days - 1) * 35;
                        double discount = price - price * 0.15;
                        double output = discount + discount * 0.25;
                        Console.WriteLine($"{output:F2}");
                    }
                    else
                    {
                        double price = (days - 1) * 35;
                        double discount = price - price * 0.15;
                        double output = discount - discount * 0.10;
                        Console.WriteLine($"{output:F2}");
                    }
                }
                else if (days > 15)
                {
                    if (evaluation == "positive")
                    {
                        double price = (days - 1) * 35;
                        double discount = price - price * 0.20;
                        double output = discount + discount * 0.25;
                        Console.WriteLine($"{output:F2}");
                    }
                    else
                    {
                        double price = (days - 1) * 35;
                        double discount = price - price * 0.20;
                        double output = discount - discount * 0.10;
                        Console.WriteLine($"{output:F2}");
                    }
                }
            }
        }
    }
}
