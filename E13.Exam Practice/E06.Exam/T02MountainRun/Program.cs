using System;

namespace T02MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double time = timeForOneMeter * distance;
            double delayTime = Math.Floor( distance / 50) * 30;
            double totalTime = time + delayTime;

            if (totalTime < record)
            {
                Console.WriteLine($" Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime - record:F2} seconds slower.");
            }
        }
    }
}
