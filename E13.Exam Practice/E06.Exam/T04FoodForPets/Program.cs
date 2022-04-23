using System;

namespace T04FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodAmount = double.Parse(Console.ReadLine());

            double totalEatenFromDog = 0;
            double totalEatenFromCat = 0;
            double totalFoodEaten = 0;
            double totalBiscuits = 0;

            for (int i = 1; i <= days; i++)
            {
                double totalFoodPerDay = 0;
                double eatenFromDog = double.Parse(Console.ReadLine());
                double eatenFromCat = double.Parse(Console.ReadLine());

                totalEatenFromCat += eatenFromCat;
                totalEatenFromDog += eatenFromDog;
                totalFoodPerDay = eatenFromCat + eatenFromDog;

                if (i % 3 == 0)
                {
                    totalBiscuits += totalFoodPerDay * 0.10; 
                }
                totalFoodEaten += totalFoodPerDay;
            }

            double percentFoodEaten = totalFoodEaten / foodAmount * 100;
            double percentDogEaten = totalEatenFromDog / totalFoodEaten * 100;
            double percentCatEaten = totalEatenFromCat / totalFoodEaten * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiscuits)}gr.");
            Console.WriteLine($"{percentFoodEaten:F2}% of the food has been eaten.");
            Console.WriteLine($"{percentDogEaten:f2}% eaten from the dog.");
            Console.WriteLine($"{percentCatEaten:f2}% eaten from the cat.");
        }
    }
}
