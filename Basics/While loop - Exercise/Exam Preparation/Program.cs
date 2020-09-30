using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputOfBadGrades = int.Parse(Console.ReadLine());
            int countForBadGrades = 0;
            double sumGrades = 0;
            int counterForGrades = 0;
            string lastProblem = string.Empty;

            while (countForBadGrades < inputOfBadGrades)
            {
                string nameOfExercise = Console.ReadLine();

                if (nameOfExercise == "Enough")
                {
                    double score = sumGrades / counterForGrades;
                    Console.WriteLine($"Average score: {score:F2}");
                    Console.WriteLine($"Number of problems: {counterForGrades}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }

                lastProblem = nameOfExercise;
                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4.00)
                {
                    countForBadGrades++;
                    counterForGrades++;
                    sumGrades += grade;
                }
                else
                {
                    sumGrades += grade;
                    counterForGrades++;
                }
            }

            if (countForBadGrades == inputOfBadGrades)
            {
                Console.WriteLine($"You need a break, {countForBadGrades} poor grades.");
            }
        }
    }
}
