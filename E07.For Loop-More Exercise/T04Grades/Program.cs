using System;

namespace T04Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            double gradeSum = 0;
            int failGradeCount = 0;
            int averageGradeCount = 0;
            int goodGradeCount = 0;
            int excellentGradeCount = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                gradeSum += grade;

                if (grade < 3)
                {
                    failGradeCount++;
                }
                else if (grade < 4)
                {
                    averageGradeCount++;
                }
                else if (grade < 5)
                {
                    goodGradeCount++;
                }
                else
                {
                    excellentGradeCount++;
                }
            }
            double failGradePercent = (double)failGradeCount / numberOfStudents * 100;
            double averageGradePercent = (double)averageGradeCount / numberOfStudents * 100;
            double goodGradePercent = (double)goodGradeCount / numberOfStudents * 100;
            double excellentGradePercent = (double)excellentGradeCount / numberOfStudents * 100;
            double averageGrade = gradeSum / numberOfStudents;

            Console.WriteLine($"Top students: {excellentGradePercent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {goodGradePercent:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {averageGradePercent:f2}%");
            Console.WriteLine($"Fail: {failGradePercent:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");
        }
    }
}
