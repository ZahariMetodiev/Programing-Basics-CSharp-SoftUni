using System;

namespace T03NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            if (flowerType == "Roses")
            {
                price = quantity * 5.00;
                if (quantity > 80)
                {
                    price *= 0.90;
                }
            }
            else if (flowerType == "Dahlias")
            {
                price = quantity * 3.80;
                if (quantity > 90)
                {
                    price *= 0.85;
                }
            }
            else if (flowerType == "Tulips")
            {
                price = quantity * 2.80;
                if (quantity > 80)
                {
                    price *= 0.85;
                }
            }
            else if (flowerType == "Narcissus")
            {
                price = quantity * 3.00;
                if (quantity < 120)
                {
                    price *= 1.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                price = quantity * 2.50;
                if (quantity < 80)
                {
                    price *= 1.20;
                }
            }

            if (price <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }
        }
    }
}
