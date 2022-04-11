using System;

namespace T04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageOfLilly = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int money = 0;
            int totalMoney = 0;
            int numberOfToys = 0;

            for (int i = 1; i <= ageOfLilly; i++)
            {
                money += 5;
                if (i % 2 == 0)
                {
                    totalMoney += money - 1;
                }
                else
                {
                    numberOfToys++;
                }
            }
            totalMoney += numberOfToys * toyPrice;

            if (totalMoney >= laundryPrice)
            {
                Console.WriteLine($"Yes! {totalMoney - laundryPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {laundryPrice - totalMoney:f2}");
            }
        }
    }
}
