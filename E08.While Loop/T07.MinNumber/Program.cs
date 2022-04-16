using System;

namespace T07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int minNum = int.MaxValue;

            while (input != "Stop")
            {
                int currentNum = int.Parse(input);
                if (currentNum < minNum)
                {
                    minNum = currentNum;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(minNum);
        }
    }
}