using System;

namespace T06NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            string winnerName = "";
            int bestPoint = 0;

            while (playerName != "Stop")
            {
                int currentPoint = 0;

                for (int i = 0; i < playerName.Length; i++)
                {
                    int num = int.Parse(Console.ReadLine());

                    if (num == playerName[i])
                    {
                        currentPoint += 10;
                    }
                    else
                    {
                        currentPoint += 2;
                    }
                }
                if (currentPoint >= bestPoint)
                {
                    bestPoint = currentPoint;
                    winnerName = playerName;
                }

                playerName = Console.ReadLine();
            }
            Console.WriteLine($"The winner is {winnerName} with {bestPoint} points!");
        }
    }
}
