using System;

namespace T03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < 200)
                {
                    p1++;
                }
                else if (currentNum < 400)
                {
                    p2++;
                }
                else if (currentNum < 600)
                {
                    p3++;
                }
                else if (currentNum < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            int totalNumbers =p1 + p2 + p3 + p4 + p5;
            double percentP1 =(double) p1 / totalNumbers * 100;
            double percentP2 =(double) p2 / totalNumbers * 100;
            double percentP3 =(double) p3/ totalNumbers * 100;
            double percentP4 =(double) p4 / totalNumbers * 100;
            double percentP5 =(double) p5 / totalNumbers * 100;
            Console.WriteLine($"{percentP1:f2}%");
            Console.WriteLine($"{percentP2:f2}%");
            Console.WriteLine($"{percentP3:f2}%");
            Console.WriteLine($"{percentP4:f2}%");
            Console.WriteLine($"{percentP5:f2}%");
        }
    }
}
