// Reference for assignment: https://byui-cse.github.io/cse210-course-2023/unit02/prepare.html
// Reference sample solution: https://github.com/byui-cse/cse210-student-sample-solutions/blob/main/prepare/Learning02/Program.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        // job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;
        // job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        // Displays "Software Engineer"
        // Console.WriteLine(myResume._jobs[0]._jobTitle);
        myResume.DisplayResumeDetails();
    }
}