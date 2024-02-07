using System;
using System.Collections.Generic;
using Develop02;
using Newtonsoft.Json;

class Program
{
    static Journal journal = new Journal();
    static bool running = true;
    //Display User Interface for Assignment
    static void DisplayInterface()
    {
        Console.WriteLine("1. Write a New Entry");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Save the Journal to a File");
        Console.WriteLine("4. Load Journal from File");
        Console.WriteLine("5. Quit Program");
        Console.Write($"Enter Number: ");
    }
    static void UserIO()
    {
        //Get command from user
        string userResponse = Console.ReadLine();
        int userNumber = int.Parse(userResponse);

        //Run user command
        if (userNumber == 1)
        {
            //Write New Entry
            journal.WriteEntry();
        }
        else if (userNumber == 2)
        {
            //Display Journal
            journal.DisplayJournal();
        }
        else if (userNumber == 3)
        {
            //Save journal to file
            journal.SaveJournal();
        }
        else if (userNumber == 4)
        {
            //Load journal
            journal.LoadJournal();
        }
        else
        {
            //Quit program
            running = false;
        }

        return;
    }
    static void Main(string[] args)
    {

        while(running)
        {
            //Display Interface
            DisplayInterface();

            //Run program
            UserIO();
        }
    }
}