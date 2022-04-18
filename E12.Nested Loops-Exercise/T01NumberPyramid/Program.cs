using System;

namespace T01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int currentNum = 1;

            for (int rows = 1; rows <= num; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(currentNum + " ");
                    currentNum++;
                    if (currentNum > num)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
