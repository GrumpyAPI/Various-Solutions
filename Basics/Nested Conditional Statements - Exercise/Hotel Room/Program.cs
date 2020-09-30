using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double apartmentPrice = 0.0;

            if (month == "May" || month == "October")
            {
                double studio = 50;
                double apartment = 65;

                if (nights > 7 && nights < 14)
                {
                    studio -= studio * 0.05;
                }
                else if (nights > 14)
                {
                    studio -= studio * 0.30;
                    apartment -= apartment * 0.10;
                }

                studioPrice = studio * nights;
                apartmentPrice = apartment * nights;
            }
            else if (month == "June" || month == "September")
            {
                double studio = 75.20;
                double apartment = 68.70;

                if (nights > 14)
                {
                    studio -= studio * 0.20;
                    apartment -= apartment * 0.10;
                }

                studioPrice = studio * nights;
                apartmentPrice = apartment * nights;
            }
            else if (month == "July" || month == "August")
            {
                double studio = 76;
                double apartment = 77;

                if (nights > 14)
                {
                    apartment -= apartment * 0.10;
                }

                studioPrice = studio * nights;
                apartmentPrice = apartment * nights;
            }

            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");

        }
    }
}
