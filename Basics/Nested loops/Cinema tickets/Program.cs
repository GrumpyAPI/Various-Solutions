using System;

namespace Cinema_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalTickets = 0;        //All of these need to be double as the percentage calculations are not accurate otherwise.
            double totalStandard = 0;
            double totalStudent = 0;
            double totalKid = 0;
            double percentageStandard = 0;
            double percentageStudent = 0;
            double percentageKid = 0;

            string ticketType = "";

            while (ticketType != "Finish")
            {
                string movieName = Console.ReadLine();
                int seats = int.Parse(Console.ReadLine());

                int standard = 0;
                int student = 0;
                int kid = 0;
                double percentageFull = 0;
                double currentTotalTickets = 0;

                while ((ticketType = Console.ReadLine()) != "End")      //For some reason it is not working with multiple conditions. It still goes inside the loop if i enter "End" or "Finish" which was the second condition.
                {
                    if (ticketType == "standard")
                    {
                        standard++;
                    }
                    if (ticketType == "student")
                    {
                        student++;
                    }
                    if (ticketType == "kid")
                    {
                        kid++;
                    }
                    if (ticketType == "Finish")
                    {
                        break;
                    }
                }
                currentTotalTickets += standard + student + kid;
                totalTickets += currentTotalTickets;
                totalStandard += standard;
                totalStudent += student;
                totalKid += kid;

                percentageFull = (currentTotalTickets / seats) * 100;
                percentageStandard = (totalStandard / totalTickets) * 100;
                percentageStudent = (totalStudent / totalTickets) * 100;
                percentageKid = (totalKid / totalTickets) * 100;

                Console.WriteLine($"{movieName} - {percentageFull:F2}% full.");
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{percentageStudent:F2}% student tickets.");
            Console.WriteLine($"{percentageStandard:F2}% standard tickets.");
            Console.WriteLine($"{percentageKid:F2}% kids tickets.");
        }
    }
}

// Shorter solution. Practically the same and yet this one brings 100% in judge.

//using System;

//namespace _06._Cinema_Tickets
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string movie = Console.ReadLine();
//            byte numStudent = 0;
//            byte numStandard = 0;
//            byte numKid = 0;
//            while (movie != "Finish")
//            {
//                byte seats = byte.Parse(Console.ReadLine());
//                byte movieTickets = 0;
//                for (int i = 0; i < seats; i++)
//                {
//                    string seatType = Console.ReadLine();
//                    if (seatType == "End")
//                    {
//                        break;
//                    }
//                    else if (seatType == "student")
//                    {
//                        numStudent++;
//                    }
//                    else if (seatType == "standard")
//                    {
//                        numStandard++;
//                    }
//                    else if (seatType == "kid")
//                    {
//                        numKid++;
//                    }
//                    movieTickets++;
//                }
//                Console.WriteLine($"{movie} - {(float)movieTickets / seats * 100:f2}% full.");
//                movie = Console.ReadLine();
//            }
//            int totalTickets = numStudent + numStandard + numKid;
//            string output = string.Format($"Total tickets: {numStudent + numStandard + numKid}\n" +
//                $"{(float)numStudent / totalTickets * 100f:f2}% student tickets.\n" +
//                $"{(float)numStandard / totalTickets * 100f:f2}% standard tickets.\n" +
//                $"{(float)numKid / totalTickets * 100f:f2}% kids tickets.");
//            Console.WriteLine(output);
//        }
//    }
//}