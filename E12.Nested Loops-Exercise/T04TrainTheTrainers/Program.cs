using System;

namespace T04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfJury = int.Parse(Console.ReadLine());
            string nameOfPresentecion = Console.ReadLine();

            int countAllPresentacion = 0;
            double sumAllGrade = 0;
            while (nameOfPresentecion != "Finish")
            {
                double sumGrade = 0;
                int currCount = 0;
                for (int i = 1; i <= numberOfJury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrade += grade;
                    sumAllGrade += grade;
                    currCount++;
                    countAllPresentacion++;
                }
                Console.WriteLine($"{nameOfPresentecion} - {sumGrade / currCount:f2}.");
                nameOfPresentecion = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {sumAllGrade / countAllPresentacion:F2}.");
        }
    }
}
