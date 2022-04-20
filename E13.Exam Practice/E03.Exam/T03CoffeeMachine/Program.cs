using System;

namespace T03CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numberOfDrinks = int.Parse(Console.ReadLine());

            double price = 0;

            switch (drink)
            {
                case "Espresso":
                    if (sugar == "Without")
                    {
                        price = numberOfDrinks * 0.90 * 0.65;
                        if (numberOfDrinks >= 5)
                        {
                            price *= 0.75;
                        }
                    }
                    else if (sugar == "Normal")
                    {
                        price = numberOfDrinks * 1.0;
                        if (numberOfDrinks >= 5)
                        {
                            price *= 0.75;
                        }

                    }
                    else if (sugar == "Extra")
                    {
                        price = numberOfDrinks * 1.20;
                        if (numberOfDrinks >= 5)
                        {
                            price *= 0.75;
                        }
                    }
                    break;
                case "Cappuccino":
                    if (sugar == "Without")
                    {
                        price = numberOfDrinks * 1.0 * 0.65; ;
                        
                    }
                    else if (sugar == "Normal")
                    {
                        price = numberOfDrinks * 1.20;
                    }
                    else if (sugar == "Extra")
                    {
                        price = numberOfDrinks * 1.60;
                    }
                    break;
                case "Tea":
                    if (sugar == "Without")
                    {
                        price = numberOfDrinks * 0.50 * 0.65;
                    }
                    else if (sugar == "Normal")
                    {
                        price = numberOfDrinks * 0.60;
                    }
                    else if (sugar == "Extra")
                    {
                        price = numberOfDrinks * 0.70;
                    }
                    break;
            }
            if (price > 15)
            {
                price *= 0.80;
            }

            Console.WriteLine($"You bought {numberOfDrinks} cups of {drink} for {price:f2} lv.");
        }
    }
}
