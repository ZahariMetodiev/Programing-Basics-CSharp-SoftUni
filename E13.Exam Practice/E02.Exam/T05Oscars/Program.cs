using System;

namespace T05Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int judgeCount = int.Parse(Console.ReadLine());

            double totalPoints = pointsFromAcademy;
            double pointsForNomination = 1250.5;

            for (int i = 0; i < judgeCount; i++)
            {
                string judgeName = Console.ReadLine();
                double pointsFromJudge = double.Parse(Console.ReadLine());

                totalPoints += judgeName.Length * pointsFromJudge / 2;

                if (totalPoints > pointsForNomination)
                {
                    Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {totalPoints:f1}!");
                    return;
                }
            }

            double neededPoints = pointsForNomination - totalPoints;
            Console.WriteLine($"Sorry, {nameOfActor} you need {neededPoints:f1} more!");
        }
    }
}
