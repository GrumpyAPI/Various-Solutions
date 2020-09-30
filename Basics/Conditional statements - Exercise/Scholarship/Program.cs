using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double gradeScholarship = 0.0;
            double socialScholarship = Math.Floor(salary * 0.35);

            if (grade >= 2.00 && grade <= 6.00)
            {
                gradeScholarship = Math.Floor(grade * 25);
            }

            if (income < salary && grade > 4.50 && grade < 5.50)        //grade < 5.50 needs to be specifically added as it seems to be going in the other "if" in some instances.
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }

            else if (grade >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {gradeScholarship} BGN");
            }

            else if (income < salary && grade >= 5.50)
            {
                if(gradeScholarship > socialScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {gradeScholarship} BGN");
                }

                else
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
            }

            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

        }
    }
}
