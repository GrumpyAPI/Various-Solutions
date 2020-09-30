using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int i = 1;
            double avarage = 0;

            while (i <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4.00)
                {
                    grade = double.Parse(Console.ReadLine());
                }
                avarage = avarage + grade;
                i++;
            }

            avarage = avarage / 12;
            Console.WriteLine($"{name} graduated. Average grade: {avarage:F2}");

        }
    }
}
