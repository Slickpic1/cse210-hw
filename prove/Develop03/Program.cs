using System;

class Program
{
    static bool DisplayPrompt(Scripture scrip)
    {
        scrip.DisplayScripture();
        Console.WriteLine($"Press enter to continue or type 'quit' to finish:");
        string response = Console.ReadLine();

        if (response == "quit")
        {
            return false;
        }
        else
        {
            Console.Clear();
            return true;
        }
    }

    static void Main(string[] args)
    {
        //Run the program

        //Initialize and display the scripture
        Scripture scrip = new Scripture();
        bool running = DisplayPrompt(scrip);

        while (!scrip.IsAllBlank() && running)
        {
            //Erase words
            scrip.EraseWords();
            running = DisplayPrompt(scrip);
            
        }
    }
}