using System;

namespace T04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int fyrstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int num1 = fyrstNum; num1 <= lastNum; num1++)
            {
                for (int num2 = fyrstNum; num2 <= lastNum; num2++)
                {
                    counter++;
                    if (num1 + num2 == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({num1} + {num2} = {magicNum})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
    }
}
