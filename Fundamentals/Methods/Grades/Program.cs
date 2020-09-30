using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            PrintInWords(grade);
        }

        static void PrintInWords(double grade)
        {
            string wording = "";

            if (grade >= 2 && grade < 3)
            {
                wording = "Fail";
            }
            else if (grade >= 3 && grade < 3.50)
            {
                wording = "Poor";
            }
            else if (grade >= 3.50 && grade < 4.50)
            {
                wording = "Good";
            }
            else if (grade >= 4.50 && grade < 5.50)
            {
                wording = "Very good";
            }
            else if (grade >= 5.50 && grade <= 6)
            {
                wording = "Excellent";
            }

            Console.WriteLine(wording);
        }
    }
}
