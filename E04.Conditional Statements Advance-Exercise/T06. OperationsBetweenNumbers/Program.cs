using System;

namespace OperationBetweenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            string oddEven = "odd";
            string output = "";
            double sum = 0;

            if (symbol == '+' || symbol == '-' || symbol == '*')
            {
                if (symbol == '+')
                {
                    sum = num1 + num2;
                }
                else if (symbol == '-')
                {
                    sum = num1 - num2;
                }
                if (symbol == '*')
                {
                    sum = num1 * num2;
                }

                if (sum % 2 == 0)
                {
                    oddEven = "even";
                }
                Console.WriteLine($"{num1} {symbol} {num2} = {sum} - {oddEven}");
            }

            else if (num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }

            else if (symbol == '/')
            {
                sum = num1 / num2;
                Console.WriteLine($"{num1} {symbol} {num2} = {sum:f2}");
            }

            else if (symbol == '%')
            {
                sum = num1 % num2;
                Console.WriteLine($"{num1} {symbol} {num2} = {sum}");
            }
        }
    }
}