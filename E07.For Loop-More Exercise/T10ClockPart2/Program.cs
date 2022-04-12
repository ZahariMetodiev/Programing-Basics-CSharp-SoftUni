using System;

namespace T10ClockPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minute = 0; minute <= 59; minute++)
                {
                    for (int second = 0; second <= 59; second++)
                    {
                        Console.WriteLine($"{hour} : {minute} : {second}");
                    }
                }
            }
        }
    }
}
