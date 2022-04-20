using System;

namespace T05PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSoldGames = int.Parse(Console.ReadLine());

            int hearthstoneCount = 0;
            int forniteCount = 0;
            int overwatchCount = 0;
            int othersCount = 0;

            for (int i = 0; i < numberOfSoldGames; i++)
            {
                string nameOfGame = Console.ReadLine();

                switch (nameOfGame)
                {
                    case "Hearthstone":
                        hearthstoneCount++;
                        break;
                    case "Fornite":
                        forniteCount++;
                        break;
                    case "Overwatch":
                        overwatchCount++;
                        break;
                    default:
                        othersCount++;
                        break;
                }
            }
            double hearthstonePercent = (double)hearthstoneCount / numberOfSoldGames * 100;
            double fornitePercent = (double)forniteCount / numberOfSoldGames * 100;
            double overwatcPercent = (double)overwatchCount / numberOfSoldGames * 100;
            double othersPercent = (double)othersCount / numberOfSoldGames * 100;

            Console.WriteLine($"Hearthstone - {hearthstonePercent:f2}%");
            Console.WriteLine($"Fornite - {fornitePercent:F2}%");
            Console.WriteLine($"Overwatch - {overwatcPercent:F2}%");
            Console.WriteLine($"Others - {othersPercent:f2}%");
        }
    }
}
