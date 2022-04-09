using System;

namespace T07HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNight = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartamentPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartamentPrice = 65;
                    if (numberOfNight > 14)
                    {
                        studioPrice *= 0.70;
                        apartamentPrice *= 0.90;
                    }
                    else if (numberOfNight > 7)
                    {
                        studioPrice *= 0.95;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartamentPrice = 68.70;
                    if (numberOfNight > 14)
                    {
                        studioPrice *= 0.80;
                        apartamentPrice *= 0.90;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartamentPrice = 77;
                    if (numberOfNight > 14)
                    {
                        apartamentPrice *= 0.90;
                    }
                    break;
            }

            double studioSum = studioPrice * numberOfNight;
            double aprtamentSum = apartamentPrice * numberOfNight;

            Console.WriteLine($"Apartment: {aprtamentSum:f2} lv.");
            Console.WriteLine($"Studio: {studioSum:f2} lv.");
        }
    }
}
