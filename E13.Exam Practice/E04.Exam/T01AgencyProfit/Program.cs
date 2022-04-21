using System;

namespace Т01AgencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidTickets = int.Parse(Console.ReadLine());
            double adultPrice = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double adultPriceWithTax = adultPrice + tax;
            double kidsPriceWithTax = adultPrice * 0.30 + tax;

            double totalSum = (adultTickets * adultPriceWithTax) + (kidTickets * kidsPriceWithTax);
            double profit = totalSum * 0.20;
            Console.WriteLine($"The profit of your agency from {companyName} tickets is {profit:f2} lv.");

        }
    }
}
