using System;

namespace T09LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < num; i++)
            {
                int fyrstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int threeNumber = int.Parse(Console.ReadLine());
                int fourNumber = int.Parse(Console.ReadLine());
                sum1 = fyrstNumber + secondNumber;
                sum2 = threeNumber + fourNumber;

                
            }
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}
