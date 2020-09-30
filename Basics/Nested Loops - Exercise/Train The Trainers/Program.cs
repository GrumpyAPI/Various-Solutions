using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jusdgesCount = int.Parse(Console.ReadLine());

            double totalAverage = 0;
            byte topicCounter = 0;

            string topic = default;

            while ((topic = Console.ReadLine()) != "Finish")
            {
                topicCounter++;
                double gradeSum = 0;

                for (int i = 0; i < jusdgesCount; i++)
                {
                    gradeSum += double.Parse(Console.ReadLine());
                }
                double averageGrade = gradeSum / jusdgesCount;
                totalAverage += averageGrade;

                Console.WriteLine($"{topic} - {gradeSum / jusdgesCount:F2}.");
            }
            Console.WriteLine($"Student's final assessment is {totalAverage / topicCounter:F2}.");
        }
    }
}

// This is the way accepted by judge. Obviously this syntax: "while ((topic = Console.ReadLine()) != "Finish")" is not acceptable. However it seems intermittent as well (not on every task). Possible judge issue (just wait it out, if not, try changing the code).
//using System;

//namespace Train_The_Trainers
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int jusdgesCount = int.Parse(Console.ReadLine());

//            double totalAverage = 0;
//            byte topicCounter = 0;

//            while (true)
//            {
//                string topic = Console.ReadLine();
//                if (topic == "Finish")
//                {
//                    break;
//                }

//                topicCounter++;
//                double gradeSum = 0;

//                for (int i = 0; i < jusdgesCount; i++)
//                {
//                    gradeSum += double.Parse(Console.ReadLine());
//                }
//                double averageGrade = gradeSum / jusdgesCount;
//                totalAverage += averageGrade;

//                Console.WriteLine($"{topic} - {gradeSum / jusdgesCount:F2}.");
//            }
//            Console.WriteLine($"Student's final assessment is {totalAverage / topicCounter:F2}.");
//        }
//    }
//}