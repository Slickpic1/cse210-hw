using System;

class Program
{
    static public World gameWorld;  //will this be readable by all classes?
    static void Main(string[] args)
    {
        //This test class will run through a variety of tests. For debugging only.
        //Test test = new Test();
        
        bool choosingOptions = true;
        while(choosingOptions)
        {
            DisplayMenu();
            choosingOptions = GetMenuChoice();
        }

        PlayGame();
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to Adventure Quest!");
        Console.WriteLine();
        Console.WriteLine("Select an option from below: ");
        Console.WriteLine("  1. New Game");
        Console.WriteLine("  2. Load Game");
        Console.WriteLine("  3. Quit");
    }

    static bool GetMenuChoice()
    {
        Console.Write("What would you like to do? ");
        string userInput = Console.ReadLine();
        bool running = true;

        switch (userInput)
        {
            //New game
            case "1":
                GenerateWorld();
                running = false;
                break;

            //Load Game
            case "2":
                break;

            //Quit (default for now)
            default:
                running = false;
                break;
        }
        return running;
    }
    public static void GenerateWorld()
    {
        //Ask player what size world they would like and gen world based on that
        Console.WriteLine("Select a world size: ");
        Console.WriteLine("  1. Small");
        Console.WriteLine("  2. Medium");
        Console.WriteLine("  3. Large");
        Console.Write("Enter size: ");
        string userInput = Console.ReadLine();

        string size = "";  //overwrite
        switch (userInput)
        {
            //Small
            case "small":
                size = "small";
                break;

            case "medium":
                size = "medium";
                break;

            case "large":
                size = "large";
                break;
        }
        gameWorld = new World(size);
    }

    static void PlayGame()
    {
        //Generate new player
        Player player = new Player();
        bool stillPlaying = true;

        while (stillPlaying)
        {
            //Describe the cell we are in
            player.Look("around");

            //Ask player what they would like to do
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            string[] inputChoices = userInput.Split(" ");

            switch (inputChoices[0])
            {
                //Look in a direction
                case "look":
                    player.Look(inputChoices[1]);
                    break;

                //Move player
                case "move":
                    player.Move(inputChoices[1]);
                    break;

                //Search around area for items
                case "search":
                    break;

                case "quit":
                    stillPlaying = false;
                    break;

                //Default is failed input
                default:
                    break;
            }
        }
    }
}