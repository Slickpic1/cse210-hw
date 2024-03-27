namespace Adventure_Qwest;
public class Cell
{
    /////////////////////////////////////////////////////////////////
    // Class: Cell
    // Description: Contains data pertaining to a world cell,
    //     including type, description, enemies, treasure, and
    //     leftover items.
    /////////////////////////////////////////////////////////////////
    
    Random rand = new Random();
    protected bool impassable = false;   //Default value, is this ok, or need to be in the call?
    protected string type;
    protected string description;
    protected string mood;
    public int[] position = {0,0};

    //To be implemented later, if possible
    //protected float enemyChanceModifier;
    //protected float treasureChanceModifier;
    //protected List<Enemy> enemies = new List<Enemy>();
    //protected List<Item> items = new List<Item>();
    //protected List<Item> treasure = new List<Item>();

    public Cell(int[] position)
    {
        //Cell with no call data for special cases. Might overwrite in the future
        this.position = position;
    }

    //Generate random cell from given list of items
    public Cell(string[] fileData, int[] position)
    {
        int terrainIndex = rand.Next(0,fileData.Length);
        GenerateCellFromFileData(fileData,terrainIndex);
        this.position = position;
    }

    //This is used when a specific cell is wanted
    public Cell(string[] fileData,int terrainIndex, int[] position) //Could be used to just generate cell, might not need other function
    {
        GenerateCellFromFileData(fileData,terrainIndex);
        this.position = position;
    }

    public string GetCellType()
    {
        return type;
    }

    public bool IsImpassable()
    {
        return impassable;
    }
    private void GenerateCellFromFileData(string[] fileData, int terrainIndex)
    {
        ////Parse into specific values (see if theres a better way)
        string terrain = fileData[terrainIndex];
        var splitData = terrain.Split(":");
        type = splitData[0];
        description = splitData[1];
        mood = splitData[2];
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


}