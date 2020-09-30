using System;

namespace Graduation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int i = 1;
            double average = 0;
            int flunk = 0;

            while (i <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4.00)
                {
                    flunk++;
                    if(flunk > 1)
                    {
                        break;
                    }
                }
                else
                {
                    average += grade;
                    i++;
                }
            }
            average = average / 12;

            if (i > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {i} grade");
            }
        }
    }
}