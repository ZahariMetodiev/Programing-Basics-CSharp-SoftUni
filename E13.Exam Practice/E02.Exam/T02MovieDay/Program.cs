using System;

namespace T02MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int shootingTime = int.Parse(Console.ReadLine());
            int numberOfScenes = int.Parse(Console.ReadLine());
            int sceneDuration = int.Parse(Console.ReadLine());

            double preparation = shootingTime * 0.15;
            double durationTime = sceneDuration * numberOfScenes + preparation;

            if (shootingTime >= durationTime)
            {
                double timeLeft = Math.Round(shootingTime - durationTime);
                Console.WriteLine($"You managed to finish the movie on time! You have {timeLeft} minutes left!");
            }
            else
            {
                double neededTime = durationTime - shootingTime;
                Console.WriteLine($"Time is up! To complete the movie you need {neededTime} minutes.");
            }
        }
    }
}
