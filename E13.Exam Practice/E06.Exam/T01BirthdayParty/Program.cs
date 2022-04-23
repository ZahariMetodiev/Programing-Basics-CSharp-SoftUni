using System;

namespace T01BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hellRent = double.Parse(Console.ReadLine());

            double cake = hellRent * 0.20;
            double drinks = cake * 0.55;
            double animator = hellRent / 3;

            double neededBudjet = hellRent + cake + drinks + animator;

            Console.WriteLine(neededBudjet);
        }
    }
}
