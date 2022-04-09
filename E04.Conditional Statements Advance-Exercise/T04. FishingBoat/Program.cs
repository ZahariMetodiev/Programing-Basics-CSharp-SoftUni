using System;

namespace T04FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFisherman = int.Parse(Console.ReadLine());
            double price = 0;

            switch (season)
            {
                case "Spring":
                    if (numberOfFisherman <= 6)
                    {
                        price = 0.90 * 3000;
                    }
                    else if (numberOfFisherman <= 11)
                    {
                        price = 0.85 * 3000;
                    }
                    else if (numberOfFisherman > 12)
                    {
                        price = 0.75 * 3000;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    if (numberOfFisherman <= 6)
                    {
                        price = 4200 * 0.90;
                    }
                    else if (numberOfFisherman <= 11)
                    {
                        price = 0.85 * 4200;
                    }
                    else if (numberOfFisherman > 12)
                    {
                        price = 0.75 * 4200;
                    }
                    break;
                case "Winter":
                    if (numberOfFisherman <= 6)
                    {
                        price = 0.90 * 2600;
                    }
                    else if (numberOfFisherman <= 11)
                    {
                        price = 0.85 * 2600;
                    }
                    else if (numberOfFisherman > 12)
                    {
                        price = 0.75 * 2600;
                    }
                    break;
            }

            if (numberOfFisherman % 2 == 0 && season != "Autumn")
            {
                price *= 0.95;
            }

            if (price <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva."); ;
            }
        }
    }
}
