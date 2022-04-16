using System;

namespace T06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int maxNum = int.MinValue;

            while (input != "Stop")
            {
                int currentNum = int.Parse(input);
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}