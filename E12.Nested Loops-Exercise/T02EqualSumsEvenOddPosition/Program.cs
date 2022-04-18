using System;

namespace T02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int fyrstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int num = fyrstNum; num <= secondNum; num++)
            {
                int currNum = num;
                int oddNum = 0;
                int evenNum = 0;
                int count = 0;

                while (currNum != 0)
                {
                    int digit = currNum % 10;
                    if (count % 2 == 0)
                    {
                        evenNum += digit;
                    }
                    else
                    {
                        oddNum += digit;
                    }
                    currNum /= 10;
                    count++;
                }

                if (evenNum == oddNum)
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
