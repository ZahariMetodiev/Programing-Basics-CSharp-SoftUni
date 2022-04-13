using System;

namespace T05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double money = 0;

            while (input != "NoMoreMoney")
            {
                double currentMoney = double.Parse(input);
                if (currentMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                money += currentMoney;
                Console.WriteLine($"Increase: {currentMoney:f2}");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {money:f2}");
        }
    }
}
