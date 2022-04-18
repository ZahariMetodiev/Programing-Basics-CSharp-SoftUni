using System;

namespace T04ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfComputers = int.Parse(Console.ReadLine());
            int totalRaiting = 0;
            double realisedSales = 0;

            for (int i = 0; i < numberOfComputers; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int raiting = num % 10;
                totalRaiting += raiting;
                int sales = num / 10;

                if (raiting == 2)
                {
                    realisedSales += 0;
                }
                else if (raiting == 3)
                {
                    realisedSales += sales / 2;
                }
                else if (raiting == 4)
                {
                    realisedSales += sales * 0.7;
                }
                else if (raiting == 5)
                {
                    realisedSales += sales * 0.85;
                }
                else if (raiting == 6)
                {
                    realisedSales += sales;
                }

            }
            Console.WriteLine($"{realisedSales:f2}");
            Console.WriteLine($"{(double)totalRaiting / numberOfComputers:f2}");
        }
    }
}
