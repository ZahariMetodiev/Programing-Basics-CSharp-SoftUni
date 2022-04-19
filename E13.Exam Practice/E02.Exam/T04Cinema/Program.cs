using System;

namespace T04Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int hellCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double incomeMoney = 0;
            double ticketPrice = 5;
            bool isFull = false;

            while (input != "Movie time!")
            {
                int incomePeople = int.Parse(input);

                if (incomePeople <= hellCapacity)
                {
                    hellCapacity -= incomePeople;
                    incomeMoney += ticketPrice * incomePeople;
                    
                    if (incomePeople % 3 == 0)
                    {
                        incomeMoney -= 5;
                    }
                    
                    input = Console.ReadLine();
                }
                else
                {
                    isFull = true;
                    break;
                }
            }

            if (isFull)
            {
                Console.WriteLine("The cinema is full.");
            }
            else
            {
                Console.WriteLine($"There are {hellCapacity} seats left in the cinema.");
            }
            Console.WriteLine($"Cinema income - {incomeMoney} lv.");
        }
    }
}
