using System;

namespace T04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();
            int stepsSum = 0;

            while (stepsSum < 10000)
            {

                if (steps == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    stepsSum += stepsToHome;
                    break;
                }
                int currentSteps = int.Parse(steps);
                stepsSum += currentSteps;
                if (stepsSum >=10000)
                {
                    break;
                }
                steps = Console.ReadLine();
            }
            if (stepsSum >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{stepsSum - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - stepsSum} more steps to reach goal.");
            }
        }
    }
}
