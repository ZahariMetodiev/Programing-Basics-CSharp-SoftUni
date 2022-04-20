using System;

namespace T04Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double totalMoney = 0;
            

            string cocktailName = Console.ReadLine();

            while (cocktailName != "Party!")
            {
                int numberOfCoctails = int.Parse(Console.ReadLine());
                double cockteilPrice = cocktailName.Length * numberOfCoctails;
                if (cockteilPrice % 2 != 0)
                {
                    cockteilPrice *= 0.75;
                }
                totalMoney += cockteilPrice;
                if (totalMoney >= neededMoney)
                {
                    Console.WriteLine($"Target acquired.");
                    break;
                }
                cocktailName = Console.ReadLine();
            }
            if (cocktailName == "Party!")
            {
                Console.WriteLine($"We need {neededMoney - totalMoney:f2} leva more.");
            }

            Console.WriteLine($"Club income - {totalMoney:f2} leva.");
        }
    }
}
