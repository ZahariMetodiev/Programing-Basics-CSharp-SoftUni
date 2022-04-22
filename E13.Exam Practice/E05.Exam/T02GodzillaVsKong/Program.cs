using System;

namespace T02GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int person = int.Parse(Console.ReadLine());
            double priceForOnePerson = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.10;
            double clothingPrice = person * priceForOnePerson;

            if (person > 150)
            {
                clothingPrice *= 0.90;
            }

            double totalMoney = clothingPrice + decorPrice;

            if (totalMoney > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalMoney - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalMoney:f2} leva left.");
            }
        }
    }
}
