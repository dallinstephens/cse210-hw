// Reference for assignment:
// https://byui-cse.github.io/cse210-course-2023/unit05/develop.html

// EXCEEDING THE REQUIREMENTS:
// 1. When a goal has been completed, the user can no longer choose it as an option when selecting "5. Record Event". 
// When selecting "5", it shows a strike through the goal to show it has been completed and cannot be selected as an option.
// 2. When a goal has been completed, an animation is displayed showing a person shouting hip, hip, hurray!

using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        int option;
        int selection;

        Goals goals = new Goals();

        do
        {
            Console.WriteLine();

            Console.WriteLine($"You have {goals.GetTotalPoints()} points.");

            Console.WriteLine();

            Console.WriteLine($"Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");

                selection = int.Parse(Console.ReadLine());

                if (selection == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.QuestionName();
                    simpleGoal.QuestionDescription();
                    simpleGoal.QuestionPoints();
                    goals.AddGoal(simpleGoal);
                }
                else if (selection == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.QuestionName();
                    eternalGoal.QuestionDescription();
                    eternalGoal.QuestionPoints();
                    goals.AddGoal(eternalGoal);
                }
                else if (selection == 3)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.QuestionName();
                    checklistGoal.QuestionDescription();
                    checklistGoal.QuestionPoints();
                    checklistGoal.QuestionTimes();
                    checklistGoal.QuestionBonus();
                    goals.AddGoal(checklistGoal);
                }
            }
            else if (option == 2)
            {
                ListGoals listGoals = new ListGoals();
                listGoals.SetGoals(goals.GetGoals());
                listGoals.RunListGoals();
            }
            else if (option == 3)
            {
                SaveGoals saveGoals = new SaveGoals();
                saveGoals.SetGoals(goals.GetGoals());
                saveGoals.SetTotalPoints(goals.GetTotalPoints());
                saveGoals.SaveFile();
            }
            else if (option == 4)
            {
                LoadGoals loadGoals = new LoadGoals();
                loadGoals.LoadFile();
                goals.SetGoals(loadGoals.GetGoals());
                goals.SetTotalPoints(loadGoals.GetTotalPoints());
            }
            else if (option == 5)
            {
                RecordEvent recordEvent = new RecordEvent();
                recordEvent.SetGoals(goals.GetGoals());
                recordEvent.SetTotalPoints(goals.GetTotalPoints());
                recordEvent.RunRecordEvent();
                goals.SetGoals(recordEvent.GetGoals());
                goals.SetTotalPoints(recordEvent.GetTotalPoints());
            }
        } while (option != 6);
    }
}