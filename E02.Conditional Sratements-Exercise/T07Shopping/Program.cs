using System;

namespace T07Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCard = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int ramMemory = int.Parse(Console.ReadLine());

            double cardPrice = videoCard * 250;
            double processorPrice = (cardPrice * 0.35) * processor;
            double memoryPrice = (cardPrice * 0.10) * ramMemory;

            double devicesPrice = cardPrice + processorPrice + memoryPrice;

            if (videoCard > processor)
            {
                devicesPrice = devicesPrice - (devicesPrice * 0.15);
            }

            if (devicesPrice <= budget)
            {
                Console.WriteLine($"You have {budget - devicesPrice:F2} leva left!");
            }
            else if (devicesPrice> budget)
            {
                Console.WriteLine($"Not enough money! You need {devicesPrice - budget:F2} leva more!");
            }
        }
    }
}
