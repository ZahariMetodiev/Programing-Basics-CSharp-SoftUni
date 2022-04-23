using System;

namespace T06TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());

            double totalEarnedMoney = 0;
            int daysWon = 0;
            int daysLose = 0;

            for (int i = 1; i <= tournamentDays; i++)
            {
                double currentMoney = 0;
                double currentWin = 0;
                double currentLose = 0;

                string sport = Console.ReadLine();

                while (sport != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        currentWin++;
                        currentMoney += 20;
                    }
                    else
                    {
                        currentLose++;
                    }

                    sport = Console.ReadLine();
                }
                if (currentWin > currentLose)
                {
                    currentMoney *= 1.10;
                    daysWon++;
                }
                else
                {
                    daysLose++;
                }
                totalEarnedMoney += currentMoney;
                
            }
            if (daysWon > daysLose)
            {
                totalEarnedMoney *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalEarnedMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalEarnedMoney:f2}");
            }

        }
    }
}
