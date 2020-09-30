using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());

                double savedMoney = 0;
                double tripSavings = 0;

                while (tripSavings < budget)
                {
                    savedMoney = double.Parse(Console.ReadLine());
                    tripSavings += savedMoney;
                }

                if (tripSavings >= budget)
                {
                    Console.WriteLine($"Going to {destination}!");
                    savedMoney = 0;
                    tripSavings = 0;
                }

                destination = Console.ReadLine();
            }
        }
    }
}
