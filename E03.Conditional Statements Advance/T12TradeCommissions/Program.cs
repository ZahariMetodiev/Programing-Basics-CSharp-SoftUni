using System;

namespace T12TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commision = 0.0;


            if (sales < 0)
            {
                Console.WriteLine("error");
            }
            else if (sales >= 0)
            {
                if (city == "Sofia")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commision = 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commision = 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commision = 0.08;
                    }
                    else if (sales > 10000)
                    {
                        commision = 0.12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (city == "Varna")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commision = 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commision = 0.075;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commision = 0.1;
                    }
                    else if (sales > 10000)
                    {
                        commision = 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (city == "Plovdiv")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commision = 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        commision = 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        commision = 0.12;
                    }
                    else if (sales > 10000)
                    {
                        commision = 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }

                if (commision != 0)
                {
                    double sum = commision * sales;
                    Console.WriteLine($"{sum:f2}");
                }
            }

        }
    }
}
