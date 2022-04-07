using System;

namespace T05GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int filmPerson = int.Parse(Console.ReadLine());
            double cloutesPrice = double.Parse(Console.ReadLine());

            double decor = filmBudget * 0.10;
            double totalCloutesPrice = cloutesPrice * filmPerson;

            if (filmPerson > 150)
            {
                totalCloutesPrice = totalCloutesPrice -  (totalCloutesPrice * 0.1);
            }

            double totalSum = totalCloutesPrice + decor;

            if (totalSum > filmBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(filmBudget - totalSum):F2} leva more.");
            }
            else if (totalSum <= filmBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudget - totalSum:F2} leva left.");
            }
        }
    }
}
