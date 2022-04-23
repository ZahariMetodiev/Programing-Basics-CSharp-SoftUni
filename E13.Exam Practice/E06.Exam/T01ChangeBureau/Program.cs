using System;

namespace T01ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBitcoin = int.Parse(Console.ReadLine());
            double numberOfChineseYuan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            int bitcoinSum = numberOfBitcoin * 1168;
            double dollarSum = numberOfChineseYuan * 0.15;
            double convertedDollar = dollarSum * 1.76;

            double sumWithoutCommision = (bitcoinSum + convertedDollar) / 1.95;
            double totalCommision = sumWithoutCommision * commision / 100;
            double totalSum = sumWithoutCommision - totalCommision;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
