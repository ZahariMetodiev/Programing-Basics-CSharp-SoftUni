using System;

namespace T02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int unsatisfactoryGrade = int.Parse(Console.ReadLine());

            int failedTimes = 0;
            double problemNumber = 0;
            int gradeSum = 0;
            string lastProblem = string.Empty;

            while (failedTimes != unsatisfactoryGrade)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    Console.WriteLine($"Average score: {gradeSum / problemNumber:f2}");
                    Console.WriteLine($"Number of problems: {problemNumber}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    return;
                }
                int currentGrade = int.Parse(Console.ReadLine());
                problemNumber++;
                gradeSum += currentGrade;
                if (currentGrade <= 4)
                {
                    failedTimes++;
                    if (failedTimes == unsatisfactoryGrade)
                    {
                        Console.WriteLine($"You need a break, {failedTimes} poor grades.");
                        return;
                    }
                }
                lastProblem = problemName;

            }
        }
    }
}
