using System;

namespace T06Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double waterBill = 20;
            double internetBill = 15;
            double totalElectricityBill = 0;
            double totalOtherBill = 0;

            for (int i = 1; i <= months; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());

                totalElectricityBill += electricityBill;
                totalOtherBill += (electricityBill + waterBill + internetBill) * 1.20;
            }

            double totalWaterBill = waterBill * months;
            double totalInternetBill = internetBill * months;
            double averageBill = (totalElectricityBill + totalOtherBill + totalInternetBill + totalWaterBill) / months;

            Console.WriteLine($"Electricity: {totalElectricityBill:f2} lv");
            Console.WriteLine($"Water: {totalWaterBill:f2} lv");
            Console.WriteLine($"Internet: {totalInternetBill:f2} lv");
            Console.WriteLine($"Other: {totalOtherBill:f2} lv");
            Console.WriteLine($"Average: {averageBill:f2} lv");
        }
    }
}
