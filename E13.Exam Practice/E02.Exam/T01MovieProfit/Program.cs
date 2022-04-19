using System;

namespace T01MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double pricePerTicket = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double profit = (tickets * pricePerTicket) * days;
            double cinemaProfit = profit * percent / 100;
            double finalProfit = profit - cinemaProfit;

            Console.WriteLine($"The profit from the movie {movieName} is {finalProfit:f2} lv.");
        }
    }
}
