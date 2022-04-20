using System;

namespace T04Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            int totalArea = height * width * 4;
            double areaForPeinting = Math.Ceiling((double)totalArea - (totalArea * percent / 100));

            string command = Console.ReadLine();

            while (command != "Tired!")
            {
                int paint = int.Parse(command);
                areaForPeinting -= paint;

                if (areaForPeinting == 0)
                {
                    Console.WriteLine($"All walls are painted! Great job, Pesho!");
                    return;
                }
                else if (areaForPeinting <= 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(areaForPeinting)} l paint left!");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{areaForPeinting} quadratic m left.");
        }
    }
}
