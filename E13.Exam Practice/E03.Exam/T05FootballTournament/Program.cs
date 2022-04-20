using System;

namespace T05FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string clubName = Console.ReadLine();
            int matches = int.Parse(Console.ReadLine());

            int wCount = 0;
            int dCount = 0;
            int lCount = 0;
            int point = 0;

            for (int i = 1; i <= matches; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                if (symbol == 'W')
                {
                    wCount++;
                    point += 3;
                }
                else if (symbol == 'D')
                {
                    dCount++;
                    point += 1;
                }
                else if (symbol == 'L')
                {
                    lCount++;
                }
            }
            double winPercent = (double)wCount / matches * 100;

            if (matches <= 0)
            {
                Console.WriteLine($"{clubName} hasn't played any games during this season.");
            }
            else
            {
                Console.WriteLine($"{clubName} has won {point} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {wCount}");
                Console.WriteLine($"## D: {dCount}");
                Console.WriteLine($"## L: {lCount}");
                Console.WriteLine($"Win rate: {winPercent:f2}%");
            }
        }
    }
}
