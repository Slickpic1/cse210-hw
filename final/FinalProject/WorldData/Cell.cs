namespace Adventure_Qwest;
using TextAnimation;
public class Cell
{
    /////////////////////////////////////////////////////////////////
    // Class: Cell
    // Description: Contains data pertaining to a world cell,
    //     including type, description, enemies, treasure, and
    //     leftover items.
    /////////////////////////////////////////////////////////////////
    
    protected Random rand = new Random();
    protected bool impassable = false;   //Default value, is this ok, or need to be in the call?
    protected string type;
    public List<string> enemyTypes = new List<string>{};
    protected string description;
    protected string mood;
    public int[] position = {0,0};
    protected List<string> terrainData;
    public MonsterData monsterData = new MonsterData();  //Might be a bad idea, but will do for now
    List<Monster> typeMonster;

    //Indexing variables
    protected int TERRAIN_INDEX;
    protected int TYPE_INDEX = 0;
    protected int DECRIPTION_INDEX = 1;
    protected int MOOD_INDEX = 2;
    protected int ENEMY_SPAWN_CHANCE_INDEX = 3;
    protected int TREASURE_SPAWN_CHANCE_INDEX = 4;
    protected int ENEMY_TYPE_INDEX = 5;

    public int enemySpawnChance = -1; //default
    protected int treasureSpawnChance = -1;  //default
    protected List<Monster> monsters = new List<Monster>();
    //protected List<Item> items = new List<Item>();
    //protected List<Item> treasure = new List<Item>();

    public Cell(int[] position)
    {
        this.position = position;
    }
    
    //This is used when a specific cell is wanted
    public Cell(int TERRAIN_INDEX, int[] position)
    {
        this.position = position;
        this.TERRAIN_INDEX = TERRAIN_INDEX;
    }

    public string GetCellType()
    {
        return type;
    }

    public bool IsImpassable()  //maybe need to rename to make more clear
    {
        return impassable;
    }
    public virtual void GenerateCell()
    {
        this.type = terrainData[TYPE_INDEX];
        this.description = terrainData[DECRIPTION_INDEX];
        this.mood = terrainData[MOOD_INDEX];
        SpawnEnemies();
    }

    public void DescribeCell()
    {
        //Console.WriteLine($"You see {description} ");
        string displayString = $"You see {description}\n";
        
        if (monsters.Count > 0)  //need to do this for multiple cases 
        {
            displayString += $"Oh no! You also spot a {monsters[0].GetName()}!\n";
        }
        TextAnimation.Program.DisplaySlowString(displayString);
    }

    public void DescribeAdjacentCell(string direction)
    {
        string neighborDesc = $"To the {direction}, you see a ";
        switch (direction)
        {
            case "north":
                neighborDesc += Program.gameWorld.world[position[0]+1,position[1]].GetCellType();
                break;

            case "south":
                neighborDesc += Program.gameWorld.world[position[0]-1,position[1]].GetCellType();
                break;

            case "east":
                neighborDesc += Program.gameWorld.world[position[0],position[1]+1].GetCellType();
                break;

            case "west":
                neighborDesc += Program.gameWorld.world[position[0],position[1]-1].GetCellType();
                break;
        }

        TextAnimation.Program.DisplaySlowString(neighborDesc + ".");
    }

    protected void ParseEnemiesString(string enemies)
    {
        string[] splitString = enemies.Split(",");
        foreach(string enemyType in splitString)
        {
            this.enemyTypes.Add(enemyType);
        }
    }

    public void SpawnEnemies()  //can loop this for multiple enemies
    {
        int spawnChance = rand.Next(0,100);
                
        //If the spawn chance we roll is <= cells enemySpawnChance, spawn enemy
        if (spawnChance <= enemySpawnChance)
        {
            //Choose a random type from the enemy types
            int typeChoice = rand.Next(0,enemyTypes.Count);
            string enemyType = enemyTypes[typeChoice];
            typeMonster = monsterData.beastiary[enemyType];

            //Choose a random monster from said types
            int monsterChoice = rand.Next(0,typeMonster.Count);  //make sure this indexes correct
            Monster monster = typeMonster[monsterChoice];

            //Add monster to list
            monsters.Add(monster); //make sure to log their position!
        }
    }
}