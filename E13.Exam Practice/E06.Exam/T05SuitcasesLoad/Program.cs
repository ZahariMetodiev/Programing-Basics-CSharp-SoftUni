using System;

namespace T05SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double occupiedSpace = 0;
            int counterBags = 0;

            while (command != "End")
            {
                double bagVolume = double.Parse(command);
                counterBags++;
                if (counterBags % 3 == 0 && counterBags != 0)
                {
                    occupiedSpace += bagVolume * 1.10;
                }
                else
                {
                    occupiedSpace += bagVolume;
                }
                if (occupiedSpace > capacity)
                {
                    counterBags--;
                    Console.WriteLine($"No more space!");
                    Console.WriteLine($"Statistic: {counterBags} suitcases loaded.");
                    return;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Congratulations! All suitcases are loaded!");
            Console.WriteLine($"Statistic: {counterBags} suitcases loaded.");
        }
    }
}
