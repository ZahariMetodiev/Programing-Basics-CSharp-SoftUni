using System;

namespace T03AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfJoinery = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string delivery = Console.ReadLine();

            double price = 0;

            if (numberOfJoinery < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }

            switch (type)
            {
                case "90X130":
                    price = 110;
                    if (numberOfJoinery > 60)
                    {
                        price *= 0.92;
                    }
                    else if (numberOfJoinery > 30)
                    {
                        price *= 0.95;
                    }
                    break;
                case "100X150":
                    price = 140;
                    if (numberOfJoinery > 80)
                    {
                        price *= 0.90;
                    }
                    else if (numberOfJoinery > 40)
                    {
                        price *= 0.94;
                    }
                    break;
                case "130X180":
                    price = 190;
                    if (numberOfJoinery > 50)
                    {
                        price *= 0.88;
                    }
                    else if (numberOfJoinery > 20)
                    {
                        price *= 0.93;
                    }
                    break;
                case "200X300":
                    price = 250;
                    if (numberOfJoinery > 50)
                    {
                        price *= 0.86;
                    }
                    else if (numberOfJoinery > 25)
                    {
                        price *= 0.91;
                    }
                    break;
            }

            double totalPrice = price * numberOfJoinery;

            if (delivery == "With delivery")
            {
                totalPrice += 60;
            }
            if (numberOfJoinery > 99)
            {
                totalPrice *= 0.96;
            }
            Console.WriteLine($"{totalPrice:f2} BGN");
        }
    }
}
