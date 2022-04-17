using System;

namespace T05AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < numbers; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
            }
            double averageNum = sum / numbers;
            Console.WriteLine($"{averageNum:f2}");
        }
    }
}
