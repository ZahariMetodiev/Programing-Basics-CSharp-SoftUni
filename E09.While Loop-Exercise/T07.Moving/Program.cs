using System;

namespace T07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomWidth = int.Parse(Console.ReadLine());
            int roomLenght = int.Parse(Console.ReadLine());
            int roomHeight = int.Parse(Console.ReadLine());

            int area = roomWidth * roomLenght * roomHeight;
            int currentArea = 0;

            string boxes = Console.ReadLine();

            while (boxes != "Done")
            {
                int currentBoxes = int.Parse(boxes);
                currentArea += currentBoxes;
                if (currentArea >= area)
                {
                    Console.WriteLine($"No more free space! You need {currentArea - area} Cubic meters more.");
                    return;
                }

                boxes = Console.ReadLine();
            }
            Console.WriteLine($"{area - currentArea} Cubic meters left.");
        }
    }
}
