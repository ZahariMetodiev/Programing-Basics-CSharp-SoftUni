using System;

namespace Т01PCStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double processorPrice = double.Parse(Console.ReadLine());
            double videCardPrice = double.Parse(Console.ReadLine());
            double ramMemoryPrice = double.Parse(Console.ReadLine());
            int numberOfRamMemory = int.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double convertedProcessorPrice = processorPrice * 1.57 ;
            double convrtedVideoCardPrice = videCardPrice * 1.57;
            double convertedRamMemotoryPrice = ramMemoryPrice * 1.57 * numberOfRamMemory;

            double totalProcessorPrice = convertedProcessorPrice - (convertedProcessorPrice * percentDiscount);
            double totalVideCardPrice = convrtedVideoCardPrice - (convrtedVideoCardPrice * percentDiscount);

            double totalSum = totalProcessorPrice + totalVideCardPrice + convertedRamMemotoryPrice;
            Console.WriteLine($"Money needed - {totalSum:f2} leva.");
        }
    }
}
