using System;
using System.Globalization;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the program!");
        return;
    }

    static string PromptUserName()
    {
        Console.Write($"Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static float FaveNumber()
    {
        Console.Write($"Please enter your favorite number: ");
        string userResponse = Console.ReadLine();
        float favNum = float.Parse(userResponse);
        return favNum;
    }

    static float SquareNumber(float number)
    {
        return number * number;
    }

    static void DisplayResult(string userName, float square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}.");
        return;
    }

    static void Main(string[] args)
    {
        // Define vars
        string username;
        float number;
        float square;

        // Display the Program welcome
        DisplayWelcome();

        // Prompt for username
        username = PromptUserName();

        // Prompt user for favorite number
        number = FaveNumber();

        //Square number and display it
        square = SquareNumber(number);
        DisplayResult(username, square);
    }
}