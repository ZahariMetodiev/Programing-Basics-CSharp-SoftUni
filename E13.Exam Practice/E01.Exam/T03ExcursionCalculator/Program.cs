using System;

namespace T03ExcursionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;

            switch (season)
            {
                case "spring":
                    if (numberOfPeople <= 5)
                    {
                        price = numberOfPeople * 50;
                    }
                    else
                    {
                        price = numberOfPeople * 48;
                    }
                    break;
                case "summer":
                    if (numberOfPeople <= 5)
                    {
                        price = numberOfPeople * 48.50;
                    }
                    else
                    {
                        price = numberOfPeople * 45;
                    }
                    price *= 0.85;
                    break;
                case "autumn":
                    if (numberOfPeople <= 5)
                    {
                        price = numberOfPeople * 60;
                    }
                    else
                    {
                        price = numberOfPeople * 49.50;
                    }
                    break;
                case "winter":
                    if (numberOfPeople <= 5)
                    {
                        price = numberOfPeople * 86;
                    }
                    else
                    {
                        price = numberOfPeople * 85;
                    }
                    price *= 1.08;
                    break;
            }

            Console.WriteLine($"{price:f2} leva.");
        }
    }
}
