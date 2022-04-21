using System;

namespace T02AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double laggagePrice = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int numberOfLaggege = int.Parse(Console.ReadLine());

            double totalLaggegePrice = 0;

            if (weight < 10)
            {
                totalLaggegePrice = laggagePrice * 0.20;
            }
            else if (weight <= 20)
            {
                totalLaggegePrice = laggagePrice * 0.50;
            }
            else
            {
                totalLaggegePrice = laggagePrice;
            }
            if (days < 7)
            {
                totalLaggegePrice *= 1.40;
            }
            else if (days <= 30)
            {
                totalLaggegePrice *= 1.15;
            }
            else
            {
                totalLaggegePrice *= 1.10;
            }

            double totalSum = totalLaggegePrice * numberOfLaggege;
            Console.WriteLine($"The total price of bags is: {totalSum:f2} lv. ");
        }
    }
}
