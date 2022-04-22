using System;

namespace T05MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFilms = int.Parse(Console.ReadLine());

            double hightestRating = double.MinValue;
            double lowestRating = double.MaxValue;
            double ratingSum = 0;
            string currentLowestName = "";
            string currentHightestName = "";

            for (int i = 1; i <= numberOfFilms; i++)
            {
                string nameOfFilm = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                ratingSum += rating;

                if (hightestRating < rating)
                {
                    hightestRating = rating;
                    currentHightestName = nameOfFilm;
                }
                if (lowestRating > rating)
                {
                    lowestRating = rating;
                    currentLowestName = nameOfFilm;
                }
            }
            double averageRating = ratingSum / numberOfFilms;

            Console.WriteLine($"{currentHightestName} is with highest rating: {hightestRating:f1}");
            Console.WriteLine($"{currentLowestName} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");
        }
    }
}
