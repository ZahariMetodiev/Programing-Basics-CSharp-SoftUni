using System;

namespace T08LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int brakeDuration = int.Parse(Console.ReadLine());

            double lunchTime = (double)brakeDuration / 8;
            double leisureTime = (double)brakeDuration / 4;
            double leftTime = brakeDuration - lunchTime - leisureTime;

            if (leftTime >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(leftTime - episodeDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(episodeDuration - leftTime)} more minutes.");
            }

        }
    }
}
