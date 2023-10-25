// Reference for assignment:
// https://byui-cse.github.io/cse210-course-2023/unit04/prepare.html
// Reference for sample solution:
// https://github.com/byui-cse/cse210-student-sample-solutions/tree/main/prepare/Learning04

using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine();

        MathAssignment mathAssignment1 = new MathAssignment("Robert Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}