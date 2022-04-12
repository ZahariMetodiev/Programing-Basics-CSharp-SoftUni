using System;

namespace T05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PRICE_FOR_FACEBOOK = 150;
            const int PRICE_FOR_INSTAGRAM = 100;
            const int PRICE_FOR_REDDIT = 50;

            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i <= openTabs; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
                string currentTab = Console.ReadLine();

                if (currentTab == "Facebook")
                {
                    salary -= PRICE_FOR_FACEBOOK;
                }
                else if (currentTab == "Instagram")
                {
                    salary -= PRICE_FOR_INSTAGRAM;
                }
                else if (currentTab == "Reddit")
                {
                    salary -= PRICE_FOR_REDDIT;
                }
            }
            Console.WriteLine(salary);
        }
    }
}
