using System;

namespace T04ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            
            int puzzles = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double toysPrice = puzzles * 2.60 + doll * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;
            int toysNumber = puzzles + doll + bears + minions + trucks;

            if (toysNumber >= 50)
            {
                toysPrice = toysPrice - (toysPrice * 0.25);
            }

            double totalPrice = toysPrice - (toysPrice * 0.10);

            if (totalPrice >= excursionPrice)
            {
                Console.WriteLine($"Yes! {totalPrice - excursionPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(excursionPrice - totalPrice):F2} lv needed.");
            }

        }
    }
}
