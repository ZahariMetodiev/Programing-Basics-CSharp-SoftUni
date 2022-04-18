using System;

namespace T06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int allStudentTicket = 0;
            int allStandardTicket = 0;
            int allKidsTicket = 0;
            int totalTickets = 0;

            while (input != "Finish")
            {
                int currStudent = 0;
                int currStandard = 0;
                int currKids = 0;
                int currTickets = 0;

                int freeSpace = int.Parse(Console.ReadLine());
                
                for (int i = 1; i <= freeSpace; i++)
                {
                    string ticketType = Console.ReadLine();
                    
                    
                    if (ticketType == "End")
                    {
                        break;
                    }
                    totalTickets++;
                    currTickets++;
                    switch (ticketType)
                    {
                        case "standard":
                            currStandard++;
                            break;
                        case "student":
                            currStudent++;
                            break;
                        case "kid":
                            currKids++;
                            break;
                    }
                }
                allStudentTicket += currStudent;
                allStandardTicket += currStandard;
                allKidsTicket += currKids;

                int allCurrTicket = currKids + currStandard + currStudent;
                double currentPercent = allCurrTicket / (double)freeSpace * 100;
                Console.WriteLine($"{input} - {currentPercent:f2}% full.");

                input = Console.ReadLine();
            }

            double studentPercent = allStudentTicket / (double)totalTickets * 100;
            double standardPercent = allStandardTicket / (double)totalTickets * 100;
            double kidsPercent = allKidsTicket / (double)totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentPercent:f2}% student tickets.");
            Console.WriteLine($"{standardPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidsPercent:f2}% kids tickets.");
        }
    }
}
