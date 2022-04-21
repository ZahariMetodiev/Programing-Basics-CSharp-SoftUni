using System;

namespace T04Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int ballNumber = int.Parse(Console.ReadLine());

            double points = 0;
            int redCount = 0;
            int orangeCount = 0;
            int yellowCount = 0;
            int whiteCount = 0;
            int blackCount = 0;
            int otherCount = 0;

            for (int i = 1; i <= ballNumber; i++)
            {
                string color = Console.ReadLine();

                switch (color)
                {
                    case "red":
                        points += 5;
                        redCount++;
                        break;
                    case "orange":
                        points += 10;
                        orangeCount++;
                        break;
                    case "yellow":
                        points += 15;
                        yellowCount++;
                        break;
                    case "white":
                        points += 20;
                        whiteCount++;
                        break;
                    case "black":
                        points = Math.Floor(points / 2);
                        blackCount++;
                        break;
                    default:
                        otherCount++;
                        break;
                }
            }

            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redCount}");
            Console.WriteLine($"Orange balls: {orangeCount}");
            Console.WriteLine($"Yellow balls: {yellowCount}");
            Console.WriteLine($"White balls: {whiteCount}");
            Console.WriteLine($"Other colors picked: {otherCount}");
            Console.WriteLine($"Divides from black balls: {blackCount}");
        }
    }
}
