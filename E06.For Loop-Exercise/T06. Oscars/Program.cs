using System;

namespace T06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int numberOfJury = int.Parse(Console.ReadLine());

            double sumPoints = pointsFromAcademy;

            for (int i = 1; i <= numberOfJury; i++)
            {
                string nameOfJury = Console.ReadLine();
                double pointsFromJury = double.Parse(Console.ReadLine());
                double momentPoints =(nameOfJury.Length * pointsFromJury) / 2;
                sumPoints += momentPoints;

                if (pointsFromAcademy > 1250.50)
                {
                    Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {sumPoints:f1}!");
                    return;
                }
                else
                {
                    Console.WriteLine($"Sorry, {nameOfActor} you need {1250.5 - sumPoints:f1} more");
                }
            }
        }
    }
}
