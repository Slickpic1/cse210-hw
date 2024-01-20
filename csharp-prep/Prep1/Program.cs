using System;

class Program
{
    static void Main(string[] args)
    {
        // Define Variables
        string firstName;
        string lastName;

        // Get User Info
        Console.Write($"What is your first name? ");
        firstName = Console.ReadLine();

        Console.Write($"What is your last name? ");
        lastName = Console.ReadLine();

        // Print user input
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}