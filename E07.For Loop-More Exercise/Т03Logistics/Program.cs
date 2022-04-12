using System;

namespace Т03Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int loads = int.Parse(Console.ReadLine());

            int minibusCount = 0;
            int truckCount = 0;
            int trainCount = 0;
            int totalCount = 0;

            for (int i = 1; i <= loads; i++)
            {
                int weight = int.Parse(Console.ReadLine());

                totalCount += weight;

                if (weight <= 3)
                {
                    minibusCount += weight;
                }
                else if (weight <= 11)
                {
                    truckCount += weight;
                }
                else
                {
                    trainCount += weight;
                }
            }

            double averagePrice = (double)(minibusCount * 200 + truckCount * 175 + trainCount * 120) / totalCount;
            double minibusPercent = (double)minibusCount / totalCount * 100;
            double truckPercent = (double)truckCount / totalCount * 100;
            double trainPercent = (double)trainCount / totalCount * 100;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{minibusPercent:f2}%");
            Console.WriteLine($"{truckPercent:f2}%");
            Console.WriteLine($"{trainPercent:f2}%");
        }
    }
}
