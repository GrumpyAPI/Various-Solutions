using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double space = width * length * height;

            bool isDone = false;
            double value = 0.0;
            double total = 0.0;

            while (isDone == false)
            {
                string input = Console.ReadLine();
                if (input != "Done")
                {
                    double convertedInput = Convert.ToDouble(input);
                    value += convertedInput;
                    total = space - value;
                    if (total <= 0)
                    {
                        double needed = Math.Abs(total);
                        Console.WriteLine($"No more free space! You need {needed} Cubic meters more.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{total} Cubic meters left.");
                    isDone = true;
                }
            }
        }
    }
}