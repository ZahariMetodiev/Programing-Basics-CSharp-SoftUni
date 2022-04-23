using System;

namespace T03FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {

            double ownedAmount = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double priceForCard = 0;

            if (gender == 'm')
            {
                switch (sport)
                {
                    case "Gym":
                        priceForCard = 42;
                        break;
                    case "Boxing":
                        priceForCard = 41;
                        break;
                    case "Yoga":
                        priceForCard = 45;
                        break;
                    case "Zumba":
                        priceForCard = 34;
                        break;
                    case "Dances":
                        priceForCard = 51;
                        break;
                    case "Pilates":
                        priceForCard = 39;
                        break;
                }
            }
            else if (gender == 'f')
            {
                switch (sport)
                {
                    case "Gym":
                        priceForCard = 35;
                        break;
                    case "Boxing":
                        priceForCard = 37;
                        break;
                    case "Yoga":
                        priceForCard = 42;
                        break;
                    case "Zumba":
                        priceForCard = 31;
                        break;
                    case "Dances":
                        priceForCard = 53;
                        break;
                    case "Pilates":
                        priceForCard = 37;
                        break;
                }
            }

            if (age <= 19)
            {
                priceForCard *= 0.80;
            }

            if (ownedAmount >= priceForCard)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${priceForCard - ownedAmount:f2} more.");
            }
        }
    }
}
