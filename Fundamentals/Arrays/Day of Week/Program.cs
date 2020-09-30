using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string[] weekDay = new string[7];

            weekDay[0] = "Monday";
            weekDay[1] = "Tuesday";
            weekDay[2] = "Wednesday";
            weekDay[3] = "Thursday";
            weekDay[4] = "Friday";
            weekDay[5] = "Saturday";
            weekDay[6] = "Sunday";

            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(weekDay[day - 1]);
            }
        }
    }
}
