using System;

namespace T08TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            const int W_POINT = 2000;
            const int F_POINT = 1200;
            const int SF_POINT = 720;

            int numberOfTournament = int.Parse(Console.ReadLine());
            int initialPoint = int.Parse(Console.ReadLine());

            int finalPoint = initialPoint;
            int wins = 0;

            for (int i = 0; i < numberOfTournament; i++)
            {
                string reachedStage = Console.ReadLine();

                if (reachedStage == "W")
                {
                    finalPoint += W_POINT;
                    wins++;
                }
                else if (reachedStage == "F")
                {
                    finalPoint += F_POINT;
                }
                else if (reachedStage == "SF")
                {
                    finalPoint += SF_POINT;
                }
            }

            double averagePoint = (double)(finalPoint - initialPoint) / numberOfTournament;
            double percentWins = (double)wins / numberOfTournament * 100;

            Console.WriteLine($"Final points: {finalPoint}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoint)}");
            Console.WriteLine($"{percentWins:f2}%");

        }
    }
}
