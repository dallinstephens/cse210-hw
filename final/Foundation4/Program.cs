// Reference for assignment:
// https://byui-cse.github.io/cse210-course-2023/unit06/project-plan.html

using System;

class Program
{
    static void Main(string[] args)
    {
        // Reference on how to create a list;
        // https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-list-in-C-Sharp/
        List<Activity> activities = new List<Activity>();

        Running running = new Running(3, "03 Mar 2024", 30);

        Cycling cycling = new Cycling(15, "05 May 2024", 45);

        Swimming swimming = new Swimming(7, "10 Jul 2024", 20);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}