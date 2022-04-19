using System;

namespace T04MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double actorBudjet = double.Parse(Console.ReadLine());
            string actorName = Console.ReadLine();


            while (actorName != "ACTION")
            {

                if (actorName.Length <= 15)
                {
                    actorBudjet -=double.Parse(Console.ReadLine());
                }
                else
                {
                    actorBudjet -= actorBudjet * 0.20;
                }

                if (actorBudjet <= 0)
                {
                    break;
                }

                actorName = Console.ReadLine();
            }

            if (actorBudjet < 0)
            {
                Console.WriteLine($"We need {Math.Abs(actorBudjet):f2} leva for our actors.");
            }
            else
            {
                Console.WriteLine($"We are left with {actorBudjet:f2} leva.");
            }
        }
    }
}
