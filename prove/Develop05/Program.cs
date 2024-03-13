using System;

class Program
{
    public static List<Goal> goalList = new List<Goal>();
    public static int totalPoints = 0;
    public static FileHandler fileHandler = new FileHandler();
    public static bool savedRecently = false;

    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");  
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
                Console.WriteLine("Error: input not recognized!");
                savedRecently = false;
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
        Console.Write("Which goal did you accompish? ");
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

        Console.WriteLine("Goals successfuly saved!");
    }

    static void LoadGoals()
    {
        //Get and set filename from user
        fileHandler.GetSetFileName();  //Better name?

        //Get raw data back from the file
        string[] rawData = fileHandler.ImportFromFile();

        //Set first of rawData to totalPoints
        totalPoints = int.Parse(rawData[0]);

        //Run through other data and sort out (skip first one)
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
        Console.Write("Select a choice from the menu: ");
        string input = Console.ReadLine();
        int userChoice = int.Parse(input);

        bool isRunning = true;

        switch(userChoice)
        {
            case 1:
                //Create new goal
                savedRecently = false; //Save first incase input fails
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
                savedRecently = true;
                break;

            case 4:
                //Load Goals
                LoadGoals();
                break;

            case 5:
                //Record Event
                RecordEvent();
                savedRecently = false;
                break;

            case 6:
                //Quit
                isRunning = false;
                if (!savedRecently)
                {
                    Console.WriteLine("You are about to exit w/ out saving!");
                    Console.Write("Would you like to save?");
                    string userResponse = Console.ReadLine();
                    bool validResponse = false;

                    //Loop until we get a valid response
                    while (!validResponse)
                    {
                        switch(userResponse)
                        {
                            case "y":
                                SaveGoals();
                                savedRecently = true;
                                validResponse = true;
                                break;

                            case "n":
                                savedRecently = true;
                                validResponse = true;
                                break;

                            default:
                                Console.WriteLine("Error: input not recognized!");
                                break;
                        }
                    }
                }
                break;

            default:
                Console.WriteLine("Error: input not recognized!");
                break;

        }
        return isRunning;
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
    }
}

////////////////////////////////////////////////////////////////////////////////
// Ideas/things to fix
////////////////////////////////////////////////////////////////////////////////
// Things to test/ check
//   1. Does every function on the menu work the way it should?              [x]
//   2. Is the output the way it should be                                   [x]
//   3. Is there a way to clean up the code a bit more?                      [x]
//
// Things to add:
//   1. Success/Fail messages for the file I/O                               [ ]
//   2. Wait times maybe?                                                    [ ]
//
// Things to fix:
//   1. Display for Record event                                             [x]
//   2. Enter filename spacing                                               [x]
//
// Ideas:
//   1. File I/O checking                                                    [ ]
//   2. Adding to files/appending to existing files                          [ ]
//   3. Checking if new data has been saved or not and asking if they want
//      to save                                                              [x]
//   4. Ability to modify list                                               [ ]
//   5. Goals that "lock" when completed                                     [ ]
//   6. Pull from list of files or read from folder                          [ ]
////////////////////////////////////////////////////////////////////////////////