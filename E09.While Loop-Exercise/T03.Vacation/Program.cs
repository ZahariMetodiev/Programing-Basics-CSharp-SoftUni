using System;

namespace T03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoneyForExcursion = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            int spendingCounter = 0;
            int dayCount = 0;


            while (ownedMoney < neededMoneyForExcursion && spendingCounter < 5)
            {
                string action = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());
                if (action == "spend")
                {
                    spendingCounter++;
                    ownedMoney -= currentMoney;
                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }
                }
                else if (action == "save")
                {
                    ownedMoney += currentMoney;
                    spendingCounter = 0;
                }
                dayCount++;
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(dayCount);
            }
            else if (ownedMoney >= neededMoneyForExcursion)
            {
                Console.WriteLine($"You saved the money for {dayCount} days.");
            }
        }
    }
}
