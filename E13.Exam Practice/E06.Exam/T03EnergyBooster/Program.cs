using System;

namespace T03EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int numberOfSet = int.Parse(Console.ReadLine());

            double price = 0;

            if (size == "small")
            {
                switch (fruit)
                {
                    case "Watermelon":
                        price = 56 * 2;
                        break;
                    case "Mango":
                        price = 36.66 * 2;
                    break;
                    case "Pineapple":
                        price = 42.10 * 2;
                        break;
                    case "Raspberry":
                        price = 20.00 * 2;
                        break;
                }
            }
            else if (size == "big")
            {
                switch (fruit)
                {
                    case "Watermelon":
                        price = 28.70 * 5;
                        break;
                    case "Mango":
                        price = 19.60 * 5;
                    break;
                    case "Pineapple":
                        price = 24.80 * 5;
                        break;
                    case "Raspberry":
                        price = 15.20 * 5;
                        break;
                }
            }
            double sum = price * numberOfSet;

            if (sum >= 400 && sum <= 1000)
            {
                sum *= 0.85;
            }
            else if (sum > 1000)
            {
                sum *= 0.50;
            }
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
