using System;

namespace T06Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int digit1 = k; digit1 <= 8; digit1++)
            {
                for (int digit2 = 9; digit2 >= l; digit2--)
                {
                    for (int digit3 = m; digit3 <= 8; digit3++)
                    {
                        for (int digit4 = 9; digit4 >= n; digit4--)
                        {
                            if (digit1 % 2 == 0 && digit3 % 2 == 0 && digit2 % 2 == 1 && digit4 % 2 == 1)
                            {
                                if (digit1 == digit3 && digit2 == digit4)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    Console.WriteLine($"{digit1}{digit2} - {digit3}{digit4}");
                                    counter++;
                                    if (counter == 6)
                                    {
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}