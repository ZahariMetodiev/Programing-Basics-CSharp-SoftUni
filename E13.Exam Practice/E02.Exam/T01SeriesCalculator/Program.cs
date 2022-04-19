using System;

namespace T01SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int numberOfSeasons = int.Parse(Console.ReadLine());
            int numberOfEpisode = int.Parse(Console.ReadLine());
            double duration = double.Parse(Console.ReadLine());

            double addTime = duration * 0.20;
            double bonusTime = numberOfSeasons * 10;
            double totalDuration = duration + addTime;

            double totalTime = totalDuration * numberOfEpisode * numberOfSeasons + bonusTime;

            Console.WriteLine($"Total time needed to watch the {serialName} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}
