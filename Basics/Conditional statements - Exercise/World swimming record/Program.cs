using System;

namespace World_swimming_record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double timePerDistance = meters * timeInSeconds;
            double delay = Math.Floor(meters / 15) * 12.5;
            double totalTime = timePerDistance + delay;

            double neededTime = totalTime - recordInSeconds;

            if (recordInSeconds <= totalTime)
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(neededTime):F2} seconds slower.");
            }

            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {Math.Abs(totalTime):F2} seconds.");
            }

        }
    }
}
