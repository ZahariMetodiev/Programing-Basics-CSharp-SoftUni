using System;

namespace T01SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secontTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secontTime + thirdTime;
            int minutes = totalTime / 60;
            int secont = totalTime % 60;

            if (secont < 10)
            {
                Console.WriteLine($"{minutes}:0{secont}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{secont}");
            }
        }
    }
}
