using System;

namespace T06WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double time = distance * timeForOneMeter;
            double totalTime = Math.Round(distance / 15) * 12.5 + time;

            if (totalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else if (totalTime >= record)
            {
                Console.WriteLine($"No, he failed! He was {totalTime - record:F2} seconds slower.");
            }
        }
    }
}
