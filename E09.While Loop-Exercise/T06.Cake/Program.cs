using System;

namespace T05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());

            int cakePieces = cakeWidth * cakeLenght;
            int takenPieces = 0;

            string numberOfPieces = Console.ReadLine();

            while (numberOfPieces != "STOP")
            {
                int currentNumberOfPieces = int.Parse(numberOfPieces);
                takenPieces += currentNumberOfPieces;
                if (takenPieces >= cakePieces)
                {
                    Console.WriteLine($"No more cake left! You need {takenPieces - cakePieces} pieces more.");
                    return;
                }
                numberOfPieces = Console.ReadLine();
            }
            Console.WriteLine($"{cakePieces - takenPieces} pieces are left.");
        }
    }
}
