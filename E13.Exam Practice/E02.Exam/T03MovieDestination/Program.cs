using System;

namespace T03MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price = 0;

            switch (destination)
            {
                case "Dubai":
                    if (season == "Winter")
                    {
                        price = 45000;
                    }
                    else if (season == "Summer")
                    {
                        price = 40000;
                    }
                    break;
                case "Sofia":
                    if (season == "Winter")
                    {
                        price = 17000;
                    }
                    else if (season == "Summer")
                    {
                        price = 12500;
                    }
                    break;
                case "London":
                    if (season == "Winter")
                    {
                        price = 24000;
                    }
                    else if (season == "Summer")
                    {
                        price = 20250;
                    }
                    break;
            }

            double totalPrice = days * price;

            if (destination == "Dubai")
            {
                totalPrice *= 0.70;
            }
            else if (destination == "Sofia")
            {
                totalPrice *= 1.25;
            }

            if (movieBudget >= totalPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {movieBudget - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {totalPrice - movieBudget:f2} leva more!");
            }
        }
    }
}
