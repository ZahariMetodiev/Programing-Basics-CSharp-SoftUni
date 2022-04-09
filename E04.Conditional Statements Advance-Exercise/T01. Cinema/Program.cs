using System;

namespace _01._
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PREMIERE_PRICE = 12.00;
            const double NORMAL_PRICE = 7.50;
            const double DISCOUNT_PRICE = 5.00;

            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            int totalPlaces = rows * colums;
            double income = 0;

            switch (type)
            {
                case "Premiere":
                    income = totalPlaces * PREMIERE_PRICE;
                    break;
                case "Normal":
                    income = totalPlaces * NORMAL_PRICE;
                    break;
                case "Discount":
                    income = totalPlaces * DISCOUNT_PRICE;
                    break;
            }

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
