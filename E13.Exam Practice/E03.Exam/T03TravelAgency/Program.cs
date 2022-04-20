using System;

namespace Т03TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            string type = Console.ReadLine();
            string discount = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price = 0;
            if (days <= 0)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            else if (days > 7)
            {
                days--;
            }

            if (cityName != "Bansko" && cityName != "Borovets" && cityName != "Varna" && cityName != "Burgas")
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            else if (type != "noEquipment" && type != "withEquipment" && type != "noBreakfast" && type != "withBreakfast")
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            if (cityName == "Bansko" || cityName == "Borovets")
            {
                if (type == "withEquipment")
                {
                    price = days * 100;
                    if (discount == "yes")
                    {
                        price *= 0.90;
                    }
                }
                else if (type == "noEquipment")
                {
                    price = days * 80;
                    if (discount == "yes")
                    {
                        price *= 0.95;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else if (cityName == "Varna" || cityName == "Burgas")
            {
                if (type == "withBreakfast")
                {
                    price = days * 130;
                    if (discount == "yes")
                    {
                        price *= 0.88;
                    }
                }
                else if (type == "noBreakfast")
                {
                    price = days * 100;
                    if (discount == "yes")
                    {
                        price *= 0.93;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
        }
    }
}
