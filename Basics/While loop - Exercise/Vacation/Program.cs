using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            int spendCounter = 0;
            int daysCounter = 0;

            while (ownedMoney < neededMoney && spendCounter < 5)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                daysCounter++;

                if (action == "spend")
                {
                    ownedMoney -= money;
                    spendCounter++;
                    if (ownedMoney <= 0)
                    {
                        ownedMoney = 0;
                    }
                    if (spendCounter == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(daysCounter);
                    }
                }
                else if (action == "save")
                {
                    ownedMoney += money;
                    spendCounter = 0;
                    if (ownedMoney >= neededMoney)
                    {
                        Console.WriteLine($"You saved the money for {daysCounter} days.");
                    }
                }
            }
        }
    }
}
