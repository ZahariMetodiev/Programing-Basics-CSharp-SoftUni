using System;

namespace T02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNum = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
            }
            int totalSum = sum - maxNum;
            if (totalSum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                int diff = Math.Abs(totalSum - maxNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
