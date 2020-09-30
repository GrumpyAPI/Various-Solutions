using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());

            int availableWeekends = 48;

            double sofiaWeekends = (availableWeekends - weekends) * 0.75;
            double holidayGames = Math.Round(holidays * 0.66666, 3);
            double totalGames = sofiaWeekends + holidayGames + weekends;

            if (yearType == "leap")
            {
                double leapGames = Math.Floor(totalGames + (totalGames * 0.15));
                Console.WriteLine(leapGames);
            }
            else
            {
                Console.WriteLine(Math.Floor(totalGames));
            }

        }
    }
}
