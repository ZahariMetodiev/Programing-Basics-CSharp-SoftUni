using System;

namespace T10InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (!(num >= 100 && num <= 200 || num == 0))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
