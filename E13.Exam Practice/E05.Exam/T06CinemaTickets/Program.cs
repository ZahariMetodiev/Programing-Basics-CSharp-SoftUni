using System;

namespace T06CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int allStudentTickets = 0;
            int allStandartTickets = 0;
            int allKidTickets = 0;
            int totalTickets = 0;

            while (command != "Finish")
            {
                int currentStudentTickets = 0;
                int currentStandartTickets = 0;
                int currentKidTickets = 0;

                int freeSpace = int.Parse(Console.ReadLine());

                for (int i = 1; i <= freeSpace; i++)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }
                    totalTickets++;
                    switch (ticketType)
                    {
                        case "student":
                            currentStudentTickets++;
                            break;
                        case "standard":
                            currentStandartTickets++;
                            break;
                        case "kid":
                            currentKidTickets++;
                            break;
                    }
                }
                allKidTickets += currentKidTickets;
                allStandartTickets += currentStandartTickets;
                allStudentTickets += currentStudentTickets;

                double currentPercent = (currentKidTickets + currentStandartTickets + currentStudentTickets) / (double)freeSpace * 100;
                Console.WriteLine($"{command} - {currentPercent:f2}% full.");
                
                command = Console.ReadLine();
            }

            double standartPercent = allStandartTickets / (double)totalTickets * 100;
            double studentPercent = allStudentTickets / (double)totalTickets * 100;
            double kidPersent = allKidTickets / (double)totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentPercent:f2}% student tickets.");
            Console.WriteLine($"{standartPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidPersent:f2}% kids tickets.");
        }
    }
}
