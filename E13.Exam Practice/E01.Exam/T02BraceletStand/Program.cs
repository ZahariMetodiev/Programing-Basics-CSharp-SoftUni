using System;

namespace T02BraceletStand
{
    class Program
    {
        static void Main(string[] args)
        {
            double pocketMoney = double.Parse(Console.ReadLine());
            double earnedMoney = double.Parse(Console.ReadLine());
            double expence = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double totalSum = (5 * pocketMoney) + (5 * earnedMoney) - expence;

            if (totalSum >= giftPrice)
            {
                Console.WriteLine($"Profit: {totalSum:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {giftPrice - totalSum:f2} BGN.");
            }
        }
    }
}
