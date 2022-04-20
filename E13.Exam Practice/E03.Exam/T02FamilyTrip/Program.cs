using System;

namespace T02FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());
            double priceForNight = double.Parse(Console.ReadLine());
            int percentCost = int.Parse(Console.ReadLine());

            if (numberOfNights > 7)
            {
                priceForNight *= 0.95;
            }

            double cost = budget * percentCost / 100;
            double totalPriceForNights = numberOfNights * priceForNight;
            double totalSum = cost + totalPriceForNights;

            if (totalSum <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - totalSum:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalSum - budget:f2} leva needed.");
            }
        }
    }
}
