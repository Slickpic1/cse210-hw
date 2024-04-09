using TextAnimation;
namespace Adventure_Qwest;
public class GameLoop
{
    public GameLoop()
    {
        Console.Clear();

        bool isStillPlaying = true;

        //Describe the cell we are in for the first time
        Program.player.Look("around");

        while (Program.player.IsAlive() && isStillPlaying)  //maybe change this to whether the player is alive or not?
        {
            //Update current position with that of the players
            int[] position = {Program.player.position[0],Program.player.position[1]};

            //Check to see if there are enemies in the current cell
            if (Program.gameWorld.world[position[0],position[1]].monsters.Count > 0)
            {
                CombatLoop combatLoop = new CombatLoop(Program.gameWorld.world[position[0],position[1]].monsters[0]);
            }

            //Check to see if player is still alive after combat
            if (!Program.player.IsAlive())
            {
                //If not, break loop.
                return;
            }

            //Ask player what they would like to do
            Console.Write("[Exploring] ");  //used to differentiate between combat and exploring
            TextAnimation.Program.DisplaySlowString("What would you like to do? ");
            string userInput = Console.ReadLine();
            string[] inputChoices = userInput.Split(" ");

            switch (inputChoices[0])
            {
                //Look in a direction
                case "look":
                    Program.player.Look(inputChoices[1]);
                    break;

                //Move player
                case "move":
                    Program.player.Move(inputChoices[1]);
                    Program.player.Look("around");
                    break;

                //Search around area for items
                case "search":
                    break;

                //Check 
                case "check":
                    if(inputChoices[1] == "health")
                    {
                        Program.player.DisplayHealthStatus();
                    }
                    
                    break;

                case "help":
                    //Display list of options for the player
                    break;

                case "rest":
                    //Heal player to full (for now)
                    TextAnimation.Program.DisplaySlowString($"You rest for a few hours.");
                    Program.player.Heal(1000);
                    Program.player.DisplayHealthStatus();
                    break;

                case "quit":
                    isStillPlaying = false;
                    break;

                //Default is failed input
                default:
                    break;
            }
        }
    }
}