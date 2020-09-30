using System;

namespace Movie_ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int movieCount = int.Parse(Console.ReadLine());

            double highestRating = 1.00;
            double lowestRating = 10.00;
            double averageRating = 0;

            string highetRatingMovieName = "";
            string lowestRatingMovieName = "";

            for (int i = 0; i < movieCount; i++)
            {
                string movieName = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                if (rating > highestRating)
                {
                    highetRatingMovieName = movieName;
                    highestRating = rating;
                }
                if (rating < lowestRating)
                {
                    lowestRatingMovieName = movieName;
                    lowestRating = rating;
                }

                averageRating += rating;
            }

            averageRating /= movieCount;

            Console.WriteLine($"{highetRatingMovieName} is with highest rating: {highestRating:F1}");
            Console.WriteLine($"{lowestRatingMovieName} is with lowest rating: {lowestRating:F1}");
            Console.WriteLine($"Average rating: {averageRating:F1}");
        }
    }
}
