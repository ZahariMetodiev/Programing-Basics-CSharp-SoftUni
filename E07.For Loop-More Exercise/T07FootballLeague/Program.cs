using System;

namespace T07FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadionCapacity = int.Parse(Console.ReadLine());
            int numberOfFens = int.Parse(Console.ReadLine());
            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;

            for (int i = 1; i <= numberOfFens; i++)
            {
                char sector = char.Parse(Console.ReadLine());

                switch (sector)
                {
                    case'A':
                        sectorA++;
                        break;
                    case 'B':
                        sectorB++;
                        break;
                    case 'V':
                        sectorV++;
                        break;
                    case 'G':
                        sectorG++;
                        break;
                }
            }

            double sectorAPercent = (double)sectorA / numberOfFens * 100;
            double sectorBPercent = (double)sectorB / numberOfFens * 100;
            double sectorVPercent = (double)sectorV / numberOfFens * 100;
            double sectorGPercent = (double)sectorG / numberOfFens * 100;
            double allFansPercent = (double)numberOfFens / stadionCapacity * 100;

            Console.WriteLine($"{sectorAPercent:F2}%");
            Console.WriteLine($"{sectorBPercent:F2}%");
            Console.WriteLine($"{sectorVPercent:f2}%");
            Console.WriteLine($"{sectorGPercent:f2}%");
            Console.WriteLine($"{allFansPercent:f2}%");

        }
    }
}
