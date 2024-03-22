public class Cell
{
    /////////////////////////////////////////////////////////////////
    // Class: Cell
    // Description: Contains data pertaining to a world cell,
    //     including type, description, enemies, treasure, and
    //     leftover items.
    /////////////////////////////////////////////////////////////////
    
    Random rand = new Random();
    private bool isTraversable;
    private string description;
    private string type;
    private string mood;
    private float enemyChanceModifier;
    private float treasureChanceModifier;
    private List<Enemy> enemies = new List<Enemy>();
    private List<Item> items = new List<Item>();
    private List<Item> treasure = new List<Item>();
    static TxtFileHandler terrainData = new TxtFileHandler("terrainData.txt");  //What does static do
    string[] fileData = terrainData.ImportFromFile();

    public Cell()
    {
        //Choose random terrainIndex
        int terrainIndex = rand.Next(0,fileData.Length);  //Test to make sure it works
        GenerateCellFromFileData(fileData,terrainIndex);

    }

    //This is used when a specific cell is wanted
    public Cell(int terrainIndex)
    {
        GenerateCellFromFileData(fileData,terrainIndex);
    }

    private void GenerateCellFromFileData(string[] fileData, int terrainIndex)
    {
        //Parse into specific values (see if theres a better way)
        string terrain = fileData[terrainIndex];
        var splitData = terrain.Split(":");
        type = splitData[0];
        description = splitData[1];
        mood = splitData[2];
        enemyChanceModifier = float.Parse(splitData[3]);
        treasureChanceModifier = float.Parse(splitData[4]);
        isTraversable = bool.Parse(splitData[5]);
    }

    public void DescribeCell()
    {
        Console.Write($"You see {description}");
    }

    public void DescribeAdjacentCell(string orientation)
    {
        
    }


}