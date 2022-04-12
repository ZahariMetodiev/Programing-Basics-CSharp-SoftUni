using System;

namespace T07TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());

            int musalaPeople = 0;
            int montBlancPeople = 0;
            int kilimandjaroPeople = 0;
            int k2People = 0;
            int everestPeople = 0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                int numberOfPeopleInGroup = int.Parse(Console.ReadLine());

                if (numberOfPeopleInGroup <= 5)
                {
                    musalaPeople += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup <= 12)
                {
                    montBlancPeople += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup <= 25)
                {
                    kilimandjaroPeople += numberOfPeopleInGroup;
                }
                else if (numberOfPeopleInGroup <= 40)
                {
                    k2People += numberOfPeopleInGroup;
                }
                else
                {
                    everestPeople += numberOfPeopleInGroup;
                }
            }

            int totalPeople = musalaPeople + montBlancPeople + kilimandjaroPeople + k2People + everestPeople;

            double musalaPercent = (double)musalaPeople / totalPeople * 100;
            double montBlancPercent = (double)montBlancPeople / totalPeople * 100;
            double kilimandjaroPercent = (double)kilimandjaroPeople / totalPeople * 100;
            double k2Percent = (double)k2People / totalPeople * 100;
            double everestPercent = (double)everestPeople / totalPeople * 100;

            Console.WriteLine($"{musalaPercent:f2}%");
            Console.WriteLine($"{montBlancPercent:f2}%");
            Console.WriteLine($"{kilimandjaroPercent:f2}%");
            Console.WriteLine($"{k2Percent:f2}%");
            Console.WriteLine($"{everestPercent:f2}%");
        }
    }
}
