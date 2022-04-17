using System;

namespace Т01Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int preparationBottle = int.Parse(Console.ReadLine());

            int preparationQuantity = preparationBottle * 750;
            int counter = 0;
            int cleanPlates = 0;
            int cleanPot = 0;

            string command = Console.ReadLine();

            while (command != "End")
            {
                int dishes = int.Parse(command);
                counter++;

                if (counter % 3 == 0)
                {
                    preparationQuantity -= dishes * 15;
                }
                else
                {
                    preparationQuantity -= dishes * 5;
                }

                if (preparationQuantity < 0)
                {
                    break;
                }
                if (counter % 3 == 0)
                {
                    cleanPot += dishes;
                }
                else
                {
                    cleanPlates += dishes;
                }
                command = Console.ReadLine();
            }

            if (preparationQuantity >= 0)
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{cleanPlates} dishes and {cleanPot} pots were washed.");
                Console.WriteLine($"Leftover detergent {preparationQuantity} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(preparationQuantity)} ml. more necessary!");
            }
        }
    }
}
