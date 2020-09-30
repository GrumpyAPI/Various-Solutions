using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailySteps = 10000;
            int totalSteps = 0;
            int currentSteps = 0;

            string input = "";

            while (totalSteps < dailySteps)
            {
                input = Console.ReadLine();

                if (input == "Going home")
                {
                    input = Console.ReadLine();
                    currentSteps = Convert.ToInt32(input);
                    totalSteps += currentSteps;
                    int neededSteps = Math.Abs(dailySteps - totalSteps);
                    if (totalSteps < dailySteps)
                    {
                        Console.WriteLine($"{neededSteps} more steps to reach goal.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                }
                else
                {
                    currentSteps = Convert.ToInt32(input);
                    totalSteps += currentSteps;
                }
                if (totalSteps >= dailySteps)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
            }
        }
    }
}
