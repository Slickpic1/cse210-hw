namespace Adventure_Qwest;

class GameEngine
{   
    private readonly Player player;
    private readonly World world;
    private bool playing = true;
    public GameEngine()
    {
        player = new Player();
        world = new World();
    }

    public void StartGame()
    {
        Console.WriteLine("Welcome to Adventure Quest!\n");
        DisplayStartMenu();

        //Main game loop
        while(true)
        {
            //Check for gameover conditions 
            if (GameOver())
            {
                return;
            }
        }
    }

    public bool DisplayStartMenu()  
    {
        Console.WriteLine("Select an option from below: ");
        Console.WriteLine("  1. New Game");
        Console.WriteLine("  2. Load Game");
        Console.WriteLine("  3. Quit");

        bool choosing = true;
        while(choosing)
        {
            Console.Write("What would you like to do? ");

            string userInput = Console.ReadLine();
            if (userInput.Length > 1)
            {
                userInput = userInput.ToLower();
            }

            switch (userInput)
            {
                //New game
                case "1":
                    world.InitializeWorld();
                    break;

                case "new game":
                    world.InitializeWorld();
                    choosing = false;
                    break;

                //Load Game
                case "2":
                    break;

                //Quit
                case "3":
                    return false;

                default:
                    Console.WriteLine("Input not recognized, please try again.\n");
                    break;
            }
        }

        return true;
    }

    private void ProcessInput(string input)
    {
        string[] inputChoices = input.Split(" ");

            switch (inputChoices[0])
            {
                //Look in a direction
                case "look":
                    player.Look(inputChoices[1]);
                    break;

                //Move player
                case "move":
                    player.Move(inputChoices[1]);
                    player.Look("around");
                    break;

                //Search around area for items
                case "search":
                    break;

                //Check 
                case "check":
                    if(inputChoices[1] == "health")
                    {
                        player.DisplayHealthStatus();
                    }
                    
                    break;

                case "help":
                    //Display list of options for the player
                    break;

                case "rest":
                    //Heal player to full (for now)
                    TextAnimation.Program.DisplaySlowString($"You rest for a few hours.");
                    player.Heal(1000);  //this is temporary
                    player.DisplayHealthStatus();
                    break;

                case "quit":
                    playing = false;
                    break;

                //Default is failed input
                default:
                    break;
            }
    }
    private bool GameOver()
    {
        if (!player.IsAlive())
        {
            TextAnimation.Program.DisplaySlowString("You have died!\n");
            return false;
        }
        else if (!playing)
        {
            TextAnimation.Program.DisplaySlowString("Thanks for playing!\n");
            return false;
        }
        else
        {
            return true;
        }
    }

    private void Combat()
    {
        
    }
}