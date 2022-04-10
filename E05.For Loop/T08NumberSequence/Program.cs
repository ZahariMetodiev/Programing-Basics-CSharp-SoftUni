using System;

namespace T08NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > maxNum)
                {
                    maxNum = number;
                }
                
                if (number < minNum)
                {
                    minNum = number;
                }
            }

            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
