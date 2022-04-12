using System;

namespace T05GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMove = int.Parse(Console.ReadLine());

            double pointSum = 0;
            int numberFrom0To9 = 0;
            int numberFrom10To19 = 0;
            int numberFrom20To29 = 0;
            int numberFrom30To39 = 0;
            int numberFrom40To50 = 0;
            int invalidNumbers = 0;

            for (int i = 0; i < numberOfMove; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0 || number > 50)
                {
                    invalidNumbers++;
                    pointSum /= 2;
                }
                else
                {
                    if (number < 10)
                    {
                        numberFrom0To9++;
                        pointSum += number * 0.20;
                    }
                    else if (number < 20)
                    {
                        numberFrom10To19++;
                        pointSum += number * 0.30;
                    }
                    else if (number < 30)
                    {
                        numberFrom20To29++;
                        pointSum += number * 0.40;
                    }
                    else if (number < 40)
                    {
                        numberFrom30To39++;
                        pointSum += 50;
                    }
                    else
                    {
                        numberFrom40To50++;
                        pointSum += 100;
                    }
                }
            }
            double numberFrom0To9Percent = (double)numberFrom0To9 / numberOfMove * 100;
            double numberFrom10To19Percent = (double)numberFrom10To19 / numberOfMove * 100;
            double numberFrom20To29Percent = (double)numberFrom20To29 / numberOfMove * 100;
            double numberFrom30To39Percent = (double)numberFrom30To39 / numberOfMove * 100;
            double numberFrom40To50Percent = (double)numberFrom40To50 / numberOfMove * 100;
            double invalidNumberPercent = (double)invalidNumbers / numberOfMove * 100;

            Console.WriteLine($"{pointSum:f2}");
            Console.WriteLine($"From 0 to 9: {numberFrom0To9Percent:F2}%");
            Console.WriteLine($"From 10 to 19: {numberFrom10To19Percent:F2}%");
            Console.WriteLine($"From 20 to 29: {numberFrom20To29Percent:f2}%");
            Console.WriteLine($"From 30 to 39: {numberFrom30To39Percent:F2}%");
            Console.WriteLine($"From 40 to 50: {numberFrom40To50Percent:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumberPercent:f2}%");
        }
    }
}
