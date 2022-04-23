using System;

namespace Т04TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroup = int.Parse(Console.ReadLine());

            int musala = 0;
            int montBlanc = 0;
            int kilimadjaro = 0;
            int k2 = 0;
            int everest = 0;
            int totalPeople = 0;

            for (int i = 1; i <= numberOfGroup; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());

                if (numberOfPeople <= 5)
                {
                    musala += numberOfPeople;
                }
                else if (numberOfPeople <= 12)
                {
                    montBlanc += numberOfPeople;
                }
                else if (numberOfPeople <= 25)
                {
                    kilimadjaro += numberOfPeople;
                }
                else if (numberOfPeople <= 40)
                {
                    k2 += numberOfPeople;
                }
                else
                {
                    everest += numberOfPeople;
                }
                totalPeople += numberOfPeople;
            }

            double percentMusala = (double)musala / totalPeople * 100;
            double percentMontBlanc = (double)montBlanc / totalPeople * 100;
            double percentKilimadjaro = (double)kilimadjaro / totalPeople * 100;
            double percentK2 = (double)k2 / totalPeople * 100;
            double percentEverest = (double)everest / totalPeople * 100;

            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMontBlanc:f2}%");
            Console.WriteLine($"{percentKilimadjaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");
        }
    }
}
