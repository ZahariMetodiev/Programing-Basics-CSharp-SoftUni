using System;

namespace T05BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();

            int hightestGoals = 0;
            string currentPlayer = "";
            int totalGoals = 0;

            while (player != "END")
            {
                int numberOfGoals = int.Parse(Console.ReadLine());

                totalGoals += numberOfGoals;
                if (numberOfGoals > hightestGoals)
                {
                    hightestGoals = numberOfGoals;
                    currentPlayer = player;
                }

                if (totalGoals >= 10)
                {
                    break;
                }

                player = Console.ReadLine();
            }

            Console.WriteLine($"{currentPlayer} is the best player!");
            if (hightestGoals >= 3)
            {
                Console.WriteLine($"He has scored {hightestGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {hightestGoals} goals.");
            }
        }
    }
}