using System;

namespace T07AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string kind = Console.ReadLine();

            if (kind == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                double squareArea = squareSide * squareSide;
                Console.WriteLine($"{squareArea:F3}");
            }
            else if (kind == "rectangle")
            {
                double rectangleSide1 = double.Parse(Console.ReadLine());
                double rectangleSide2 = double.Parse(Console.ReadLine());
                double rectangleArea = rectangleSide1 * rectangleSide2;
                Console.WriteLine($"{rectangleArea:F3}");
            }
            else if (kind == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * circleRadius * circleRadius;
                Console.WriteLine($"{circleArea}");
            }
            else if (kind == "triangle")
            {
               double triangleSite = double.Parse(Console.ReadLine());
               double triangleHeight = double.Parse(Console.ReadLine());
               double triangleArea = triangleSite * triangleHeight / 2;
                Console.WriteLine($"{triangleArea:F3}");
            }
        }
    }
}
