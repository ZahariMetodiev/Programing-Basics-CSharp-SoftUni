using System;

namespace T06FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            string bestMovie = "";
            int movieCounter = 0;
            int ASCIISum = 0;
            int bestASCIISum = int.MinValue;

            while (movieName != "STOP")
            {
                int currentASCIISum = 0;

                for (int i = 0; i < movieName.Length; i++)
                {
                    currentASCIISum += movieName[i];

                    if (movieName[i] >= 97 && movieName[i] <= 122)
                    {
                        currentASCIISum -= movieName.Length * 2;
                    }
                    else if(movieName[i] >= 65 && movieName[i] <= 90)
                    {
                        currentASCIISum -= movieName.Length;
                    }
                }
                
                if (currentASCIISum > bestASCIISum)
                {
                    bestMovie = movieName;
                    bestASCIISum = currentASCIISum;
                }

                movieCounter++;
                
                if (movieCounter >= 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }

                movieName = Console.ReadLine();
            }

            Console.WriteLine($"The best movie for you is {bestMovie} with {bestASCIISum} ASCII sum.");
        }
    }
}
