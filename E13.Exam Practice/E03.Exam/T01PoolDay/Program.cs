using System;

namespace Т01PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double sunbed = double.Parse(Console.ReadLine());
            double umbrella = double.Parse(Console.ReadLine());

            double sunbedPrice = Math.Ceiling(people * 0.75) * sunbed;
            double umbrellaPrice = Math.Ceiling(people / 2.00) * umbrella;
            double taxSum = people * tax;

            double total = sunbedPrice + umbrellaPrice + taxSum;

            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
