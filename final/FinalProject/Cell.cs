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
    protected List<string> enemyTypes = new List<string>{};
    protected string description;
    protected string mood;
    public int[] position = {0,0};
    protected List<string> terrainData;

    //Indexing variables
    protected int TERRAIN_INDEX;
    protected int TYPE_INDEX = 0;
    protected int DECRIPTION_INDEX = 1;
    protected int MOOD_INDEX = 2;
    protected int ENEMY_SPAWN_CHANCE_INDEX = 3;
    protected int TREASURE_SPAWN_CHANCE_INDEX = 4;
    protected int ENEMY_TYPE_INDEX = 5;

    protected int enemySpawnChance = 0; //default
    protected int treasureSpawnChance;  //default
    //protected List<Enemy> enemies = new List<Enemy>();
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
    }

    public void DescribeCell()
    {
        Console.WriteLine($"You see {description} ");
    }

    public void DescribeAdjacentCell(string direction)
    {
        string neighborDesc = $"To the {direction}, you see a ";
        switch (direction)
        {
            case "north":
                Console.WriteLine(position[0]);
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

        Console.WriteLine(neighborDesc + ".");  //Will format this later
    }

    protected void ParseEnemiesString(string enemies)
    {
        string[] splitString = enemies.Split(",");
        foreach(string enemyType in splitString)
        {
            this.enemyTypes.Add(enemyType);
        }
    }
}