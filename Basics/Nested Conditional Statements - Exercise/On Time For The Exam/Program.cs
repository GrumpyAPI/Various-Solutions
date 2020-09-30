using System;

namespace On_Time_For_The_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfTheExam = int.Parse(Console.ReadLine());
            int minuteOfTheExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            int totalMinutesExam = hourOfTheExam * 60 + minuteOfTheExam;
            int totalMinutesArrival = hourOfArrival * 60 + minuteOfArrival;

            int timeDifference = totalMinutesExam - totalMinutesArrival;

            if (timeDifference < 0)
            {
                Console.WriteLine("Late");

                int timeDifferenceAbsoluteValue = Math.Abs(timeDifference);
                if (timeDifferenceAbsoluteValue < 60)
                {
                    Console.WriteLine($"{timeDifferenceAbsoluteValue} minutes after the start");
                }
                else
                {
                    int hour = timeDifferenceAbsoluteValue / 60;
                    int minutes = timeDifferenceAbsoluteValue % 60;
                    Console.WriteLine($"{hour}:{minutes:D2} hours after the start");
                }
            }
            else if (timeDifference > 30)
            {
                Console.WriteLine("Early");
                if (timeDifference < 60)
                {
                    Console.WriteLine($"{timeDifference} minutes before the start");
                }
                else
                {
                    int hour = timeDifference / 60;
                    int minutes = timeDifference % 60;
                    Console.WriteLine($"{hour}:{minutes:D2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                if (timeDifference != 0)
                {
                    Console.WriteLine($"{timeDifference} minutes before the start");
                }
            }

        }
    }
}
