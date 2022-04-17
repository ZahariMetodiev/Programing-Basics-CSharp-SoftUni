using System;

namespace T02ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededMoney = int.Parse(Console.ReadLine());

            int counter = 1;
            int totalSum = 0;
            int cashSum = 0;
            int cardSum = 0;
            int cashCounter = 0;
            int cardCounter = 0;

            string command = Console.ReadLine();

            while (command != "End")
            {
                int price = int.Parse(command);
                counter++;

                if (counter % 2 == 0)
                {
                    if (price <= 100)
                    {
                        Console.WriteLine("Product sold!");
                        cashCounter++;
                        cashSum += price;
                        totalSum += price;
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                else
                {
                    if (price > 10)
                    {
                        Console.WriteLine("Product sold!");
                        cardCounter++;
                        cardSum += price;
                        totalSum += price;
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                if (totalSum >= neededMoney)
                {
                    break;
                }
                command = Console.ReadLine();
            }

            double averageCashSum = (double)cashSum / cashCounter;
            double averageCardSum = (double)cardSum / cardCounter;


            if (totalSum < neededMoney)
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
            else
            {
                Console.WriteLine($"Average CS: {averageCashSum:f2}");
                Console.WriteLine($"Average CC: {averageCardSum:f2}");
            }

        }
    }
}
