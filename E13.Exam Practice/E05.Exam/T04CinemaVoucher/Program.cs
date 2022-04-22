using System;

namespace T04CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int vaucherAmount = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int ticketCounter = 0;
            int anotherCounter = 0;
            int sum = 0;

            while (command != "End")
            {
                if (command.Length > 8)
                {
                    sum += command[0] + command[1];
                    if (sum > vaucherAmount)
                    {
                        break;
                    }
                    ticketCounter++;
                }
                else
                {
                    sum += command[0];
                    if (sum > vaucherAmount)
                    {
                        break;
                    }
                    anotherCounter++;
                }
                
                command = Console.ReadLine();
            }
            Console.WriteLine(ticketCounter);
            Console.WriteLine(anotherCounter);
        }
    }
}
