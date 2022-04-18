using System;

namespace T03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            int sumOfPrimeNumbers = 0;
            int sumOfNonNumbers = 0;

            while (comand != "stop")
            {
                int num = int.Parse(comand);
                if (num < 0)
                {
                    Console.WriteLine($"Number is negative.");
                }
                else
                {
                    int count = 0;
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        sumOfPrimeNumbers += num;
                    }
                    else
                    {
                        sumOfNonNumbers += num;
                    }
                    
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrimeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonNumbers}");
        }
    }
}
