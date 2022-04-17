using System;

namespace T05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
            
            while (destination != "End")
            {
                double neededBudget = double.Parse(Console.ReadLine());

                double savedMoney = 0;
                while (savedMoney < neededBudget)
                {
                    double money = double.Parse(Console.ReadLine());
                    savedMoney += money;
                    
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
                
            }
        }
    }
}
