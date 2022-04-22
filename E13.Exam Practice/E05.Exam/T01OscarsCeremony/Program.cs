using System;

namespace T01OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int hellRent = int.Parse(Console.ReadLine());

            double statuettesPrice = hellRent * 0.70;
            double cateringPrice = statuettesPrice * 0.85;
            double soundSystem = cateringPrice / 2;

            double totalSum = hellRent + statuettesPrice + cateringPrice + soundSystem;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
