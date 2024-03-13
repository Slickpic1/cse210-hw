using System;

class Program
{
    //Not sure if this should be static or not...
    public static List<Goal> goalList = new List<Goal>();  //Should this be here
    public static int totalPoints = 0;  //Might need to change later
    //Initialize fileHandler class
    public static FileHandler fileHandler = new FileHandler();
    static void DisplayMenu()
    {
        //Need to display points first

        Console.WriteLine("Menu Options: ");  //Could potentially compact this, but would make more obscure
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
    }

    static void DisplayGoalMenu()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }

    static void GoalChoice()
    {
        Console.Write("Which type of goal would you like to create? ");
        string input = Console.ReadLine();
        int userChoice = int.Parse(input);

        switch(userChoice)
        {
            case 1:
                //Simple Goal
                SimpleGoal simpleGoal = new SimpleGoal();
                goalList.Add(simpleGoal);
                break;
            
            case 2:
                //Eternal Goal
                EternalGoal eternalGoal = new EternalGoal();
                goalList.Add(eternalGoal);
                break;

            case 3:
                //Checklist Goal
                ChecklistGoal checklistGoal = new ChecklistGoal();
                goalList.Add(checklistGoal);
                break;

            default:
                break;
        }
    }

    static void ListGoals()
    {
        int i = 1;
        Console.WriteLine("The goals are: ");
        foreach (var goal in goalList)
        {
            Console.Write($"{i}. ");
            goal.DisplayGoal();
            i++;
        }
    }

    static void RecordEvent()
    {
        //List the goal titles currently present
        int i = 1;
        Console.WriteLine("The goals are: ");
        foreach (var goal in goalList)
        {
            Console.Write($"{i}. ");
            Console.WriteLine(goal.GetGoalTitle());
            i++;
        }

        //Find out what goal they accomplished
        Console.Write("Which goal did you accompish");
        int userInput = int.Parse(Console.ReadLine());
        userInput--; //Reduce the input by 1 for indexing

        //Get the points
        int points = goalList[userInput].GetPoints();

        //Display and add points
        totalPoints += points;
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Console.WriteLine($"You now have {totalPoints} points.");
    }

    static void SaveGoals()
    {
        //Get and set filename from user
        fileHandler.GetSetFileName();

        //Save score and list of goals
        fileHandler.ExportToFile(totalPoints,goalList);
    }

    static void LoadGoals()
    {
        //Get and set filename from user
        fileHandler.GetSetFileName();  //Better name?

        //Get raw data back from the file
        string[] rawData = fileHandler.ImportFromFile();

        //Set first of rawData to totalPoints
        totalPoints = int.Parse(rawData[0]);

        //Run through other data and sort out
        foreach (string goals in rawData.Skip(1))
        {
            //Parse out first value to determine type
            string type = goals.Split(":")[0];
            Console.WriteLine(type);
            string values = goals.Split(":")[1];

            switch (type)
            {
                case "Simple Goal":  //Make sure not assigning type twice
                    SimpleGoal simpleGoal = new SimpleGoal(values);
                    goalList.Add(simpleGoal);
                    break;

                case "Eternal Goal":
                    EternalGoal eternalGoal = new EternalGoal(values);
                    goalList.Add(eternalGoal);
                    break;

                case "Checklist Goal":
                    ChecklistGoal checklistGoal = new ChecklistGoal(values);
                    goalList.Add(checklistGoal);
                    break;
            }

        }
    }

    static bool MenuChoice()
    {
        //Get user input
        Console.Write("Select a choice from the menu:");
        string input = Console.ReadLine();
        int userChoice = int.Parse(input);

        bool isRunning = true;

        switch(userChoice)
        {
            case 1:
                //Create new goal
                DisplayGoalMenu();
                GoalChoice();
                break;
            
            case 2:
                //List Goals
                ListGoals();
                break;

            case 3:
                //Save Goals
                SaveGoals();
                break;

            case 4:
                //Load Goals
                LoadGoals();
                break;

            case 5:
                //Record Event
                RecordEvent();
                break;

            default:
                isRunning = false;
                break;

        }
        return isRunning;
    }

    //This is a test function meant to test various features. Remove when done
    static void Test()
    {
        //int testPoints = 12;
        //string testTitle = "Give a talk";
        //string testDesc = "Don't be bad";

        string testValues = $"Simple Goal:Be Good~Don't be bad~10~~true";

        Console.Clear();

        //SimpleGoal goal1 = new SimpleGoal();
        //goal1.DisplayGoal();

        ChecklistGoal goal2 = new ChecklistGoal();
        goal2.DisplayGoal();

        SimpleGoal goal1 = new SimpleGoal(testValues);
        goal1.DisplayGoal();

        goalList.Add(goal1);
        goalList.Add(goal2);

        //Test file writing
        string testExport = goal1.Export();
        fileHandler.ExportToFile(100,goalList);

        ListGoals();

    }

    static void Main(string[] args)
    {
        //Run through our menu and then loop indef til user input
        bool isRunning = true;
        Console.Clear();
        while (isRunning)
        {
            Console.WriteLine($"\nScore: {totalPoints}\n");
            DisplayMenu();
            isRunning = MenuChoice();
        }
        //Test();
    }
}