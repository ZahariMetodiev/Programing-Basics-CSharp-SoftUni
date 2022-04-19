using System;

namespace T03FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionName = Console.ReadLine();
            string package = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double price = 0;

            switch (projectionName)
            {
                case "John Wick":
                    switch (package)
                    {
                        case "Drink":
                            price = 12;
                            break;
                        case "Popcorn":
                            price = 15;
                            break;
                        case "Menu":
                            price = 19;
                            break;
                    }
                    break;
                case "Star Wars":
                    switch (package)
                    {
                        case "Drink":
                            price = 18;
                            break;
                        case "Popcorn":
                            price = 25;
                            break;
                        case "Menu":
                            price = 30;
                            break;
                    }
                    break;
                case "Jumanji":
                    switch (package)
                    {
                        case "Drink":
                            price = 9;
                            break;
                        case "Popcorn":
                            price = 11;
                            break;
                        case "Menu":
                            price = 14;
                            break;
                    }
                    break;
            }

            double totalTicketPrice = tickets * price;

            if (projectionName == "Star Wars" && tickets >= 4)
            {
                totalTicketPrice *= 0.70;
            }
            else if (projectionName == "Jumanji" && tickets == 2)
            {
                totalTicketPrice *= 0.85;
            }

            Console.WriteLine($"Your bill is {totalTicketPrice:f2} leva.");
        }
    }
}
