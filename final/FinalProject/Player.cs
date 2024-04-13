using System.Diagnostics;

namespace Adventure_Qwest;
public class Player : Entity
{
    public int proficiencyBonus;
    private int score;               
    private string previousDirection;
    public Player() : base()
    {
        position[0] = 1;  //Better way to do this?
        position[1] = 1;

        //Set player stats
        stats["str"] = 15;

        //Set players base HP and AC
        AC = 15;
        maxHP = 25;
        currentHP = maxHP;
        proficiencyBonus = 2;

        //Initialize attackDesc list
        attackDescriptions = new List<string>
        {
            ""
        };
    }

    public override string Action()
    {
        //Display list of actions to player and let them decide
        Console.WriteLine("=====================================================");
        Console.WriteLine("   Actions:");
        Console.WriteLine("=====================================================");
        Console.WriteLine("      [1]. Attack                  [3]. Run Away!");
        Console.WriteLine("");
        Console.WriteLine("      [2]. Act                     [4]. Item     ");
        Console.WriteLine("=====================================================\n");
        Console.Write("[Combat] What would you like to do? ");

        //Read player input and run appropriate function
        string userInput = Console.ReadLine();
        string action = "NA";

        switch(userInput)  //need a default for failed values
        {
            case "1":
            //Attack
                action = "attack";
                break;

            case "2":
            //Act
                action = "act";
                break;

            case "3":
            //Run away
                action = "flee";
                break;
            
            case "4":
            //Use an item
                action = "use item";
                break;

            default:
                break;
        }
        return action;
    }

    public override int AttackRoll()
    {
        int attack = Dice.Dice.RollD20() + (stats["str"]-10)/2 + proficiencyBonus;  
        TextAnimation.Program.DisplaySlowString("");
        return attack;
    }

    public override int DamageRoll()
    {
        //For the basic code, we will allow the player to use a sword
        int damage = Dice.Dice.RollD6() + (stats["str"]-10)/2;  
        return damage;
    }
    public void Move(string direction)
    {
        // Determine where the new position will be
        int xPos = position[1];
        int yPos = position[0];
        int[] newPosition = {yPos,xPos};

        //#Debug Stuff
        Debug.WriteLine($"Position: {xPos},{yPos}");
        Debug.WriteLine($"Previous Direction: {previousDirection}");

        switch (direction)
        {
            case "north":
                newPosition[0] += 1;
                previousDirection = "south";
                break;

            case "south":
                newPosition[0] -= 1;
                previousDirection = "north";
                break;

            case "east":
                newPosition[1] += 1;
                previousDirection = "west";
                break;

            case "west":
                newPosition[1] -= 1;
                previousDirection = "east";
                break;

            case "back":
                Move(previousDirection);
                break;
        }

        //Check to see if place player wants to go is traversable
        if (Program.gameWorld.world[newPosition[0],newPosition[1]].IsImpassable())
        {
            Console.WriteLine($"You cannot traverse {Program.gameWorld.world[newPosition[0],newPosition[1]].GetCellType()}");
        }
        else
        {
            //Update position if legal
            position[0] = newPosition[0];
            position[1] = newPosition[1];
        }
    }

    public void Look(string direction)
    {
        switch (direction)
        {
            case "north":
                Program.gameWorld.world[position[0],position[1]].DescribeAdjacentCell(direction);
                break;

            case "south":
                Program.gameWorld.world[position[0],position[1]].DescribeAdjacentCell(direction);
                break;

            case "east":
                Program.gameWorld.world[position[0],position[1]].DescribeAdjacentCell(direction);
                break;

            case "west":
                Program.gameWorld.world[position[0],position[1]].DescribeAdjacentCell(direction);
                break;

            case "around":
                Program.gameWorld.world[position[0],position[1]].DescribeCell();
                break;
        }
        
    }

    public override void DisplayHealthStatus()
    {   TextAnimation.Program.DisplaySlowString("You are");
        base.DisplayHealthStatus();
    }

    public void Heal(int HP)
    {   
        if (HP > maxHP)
        {
            currentHP = maxHP;
        }
        else
        {
            currentHP += HP;
        }
    }

    public void AddXP(int enemyXP)
    {
        score += enemyXP;
    }

    public int GetScore()
    {
        return score;
    }

    public void Death()
    {
        
        TextAnimation.Program.DisplaySlowString($"Your score is {score}\n");
    }
}