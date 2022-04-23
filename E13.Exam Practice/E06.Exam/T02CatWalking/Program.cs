using System;

namespace T02CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalk = int.Parse(Console.ReadLine());
            int numberOfWalk = int.Parse(Console.ReadLine());
            double calories = double.Parse(Console.ReadLine());

            int totalMinutesForWalk = minutesWalk * numberOfWalk;
            double totalCalories = totalMinutesForWalk * 5;
            double neededCalories = calories / 2;

            if (totalCalories >= neededCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCalories}.");
            }
        }
    }
}
