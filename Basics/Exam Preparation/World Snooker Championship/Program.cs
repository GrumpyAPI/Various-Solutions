using System;

namespace World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketAmount = int.Parse(Console.ReadLine());
            string photo = Console.ReadLine();

            double standardTicket = 0;
            double premiumTicket = 0;
            double vipTicket = 0;
            double ticketSum = 0;

            if (stage == "Quarter final")
            {
                standardTicket = 55.50;
                premiumTicket = 105.20;
                vipTicket = 118.90;
            }
            else if (stage == "Semi final")
            {
                standardTicket = 75.88;
                premiumTicket = 125.22;
                vipTicket = 300.40;
            }
            else if (stage == "Final")
            {
                standardTicket = 110.10;
                premiumTicket = 160.66;
                vipTicket = 400;
            }

            if (ticketType == "Standard")
            {
                ticketSum = standardTicket * ticketAmount;
            }
            else if (ticketType == "Premium")
            {
                ticketSum = premiumTicket * ticketAmount;
            }
            else if (ticketType == "VIP")
            {
                ticketSum = vipTicket * ticketAmount;
            }

            if (ticketSum > 4000)
            {
                ticketSum = ticketSum - (ticketSum * 0.25);
            }
            else if (ticketSum > 2500 && ticketSum <= 4000)
            {
                ticketSum = ticketSum - (ticketSum * 0.10);
                if (photo == "Y")
                {
                    ticketSum += 40 * ticketAmount;
                }
            }
            else if (ticketSum <= 2500 && photo == "Y")
            {
                ticketSum += 40 * ticketAmount;
            }
            Console.WriteLine($"{ticketSum:F2}");
        }
    }
}
