using System;

namespace T05CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodAmount = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int convertedFood = foodAmount * 1000;
            int totalFood = 0;

            while (command != "Adopted")
            {
                int currentFood = int.Parse(command);
                totalFood += currentFood;
                command = Console.ReadLine();
            }

            if (totalFood <= convertedFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {convertedFood - totalFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalFood - convertedFood} grams more.");
            }
        }
    }
}
