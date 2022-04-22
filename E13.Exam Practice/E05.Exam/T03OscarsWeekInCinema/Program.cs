using System;

namespace T03OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {

            string nameOfFilm = Console.ReadLine();
            string hellType = Console.ReadLine();
            int numberOfTickets = int.Parse(Console.ReadLine());
            
            double priceForTicket = 0;

            if (hellType == "normal")
            {
                switch (nameOfFilm)
                {
                    case "A Star Is Born":
                        priceForTicket = 7.50;
                        break;
                    case "Bohemian Rhapsody":
                        priceForTicket = 7.35;
                        break;
                    case "Green Book":
                        priceForTicket = 8.15;
                        break;
                    case "The Favourite":
                        priceForTicket = 8.75;
                        break;
                }
            }
            else if (hellType == "luxury")
            {
                switch (nameOfFilm)
                {
                    case "A Star Is Born":
                        priceForTicket = 10.50;
                        break;
                    case "Bohemian Rhapsody":
                        priceForTicket = 9.45;
                        break;
                    case "Green Book":
                        priceForTicket = 10.25;
                        break;
                    case "The Favourite":
                        priceForTicket = 11.55;
                        break;
                }
            }
            else if (hellType == "ultra luxury")
            {
                switch (nameOfFilm)
                {
                    case "A Star Is Born":
                        priceForTicket = 13.50;
                        break;
                    case "Bohemian Rhapsody":
                        priceForTicket = 12.75;
                        break;
                    case "Green Book":
                        priceForTicket = 13.25;
                        break;
                    case "The Favourite":
                        priceForTicket = 13.95;
                        break;
                }
            }
            double totalPrice = numberOfTickets * priceForTicket;
            Console.WriteLine($"{nameOfFilm} -> {totalPrice:f2} lv.");
        }
    }
}
