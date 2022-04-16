using System;

namespace T08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int clas = 1;
            int failAtempts = 0;
            double gradeAmount = 0;


            while (clas <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                gradeAmount += grade;
                if (grade < 4)
                {
                    failAtempts++;
                    if (failAtempts == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {clas} grade");
                        return;
                    }
                    continue;
                }
                clas++;

            }
            double averageGrade = gradeAmount / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}