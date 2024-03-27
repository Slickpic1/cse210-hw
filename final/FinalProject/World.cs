using System.Drawing;

namespace Adventure_Qwest;
public class World
{
    ///////////////////////////////////////////////////////////////////////////
    //  Class: World
    //  Description: Generates the world from different cells. First constructs
    //       the world border out of mountains and then populates interior with
    //       random cells. Currently overwrites top left with spawn.
    ///////////////////////////////////////////////////////////////////////////
    /// Note: BE VERY CAREFUL ABOUT HOW WE ARE READING THE ARRAY

    Random random = new Random();
    
    static TxtFileHandler terrainData = new TxtFileHandler("terrainData.txt");  //What does static do
    static TxtFileHandler impassableTerrainData = new TxtFileHandler("impassableTerrainData.txt");
    static TxtFileHandler safeTerrainData = new TxtFileHandler("safeTerrainData.txt");
    static TxtFileHandler normalTerrainData = new TxtFileHandler("normalTerrainData.txt");
    static TxtFileHandler hostileTerrainData = new TxtFileHandler("hostileTerrainData.txt");
    private int size = 11;             //if not zero, returns error with below function (not sure why)
    public Cell[,] world;              //not sure if this is legal

    public int GetSize()
    {
        return size;
    }
    public World(string worldSize)
    {
        switch (worldSize)  //Maybe default to small?
        {
            case "small":
                size = 11;
                break;

            case "medium":
                size = 21;
                break;
            
            case "large":
                size = 31;
                break;

            default:
                Console.WriteLine("Input not recognized");
                break;
        }

        world = new Cell[size,size];   //Be careful here, im not sure how referencing and pointers work here

        //Generate our world
        GenerateWorldBorder(size);
        GenerateWorldInterior(size);
        GenerateWorldSpawn();
    }

    private void GenerateWorldBorder(int size)
    {
        //Import the impassable terrain data
        string[] borderData = impassableTerrainData.ImportFromFile();

        //Create a basic mountain type cell
        Cell mountain;// = new ImpassableCell(borderData,0);   //NEED TO UPDATE TO FIT FILEDATA DESCRIPTION

        //Run along vertical axis
        for (int i = 0; i < size;i++)
        {
            //If top or bottom, fill every cell position with mountains
            if (i == 0 || i == size-1)
            {
                //Run through every horizontal position
                for (int j = 0; j < size; j++)
                {
                    int[] position = {i,j};
                    mountain = new ImpassableCell(borderData,0,position);
                    world[i,j] = mountain;
                }
            }

            //Otherwise, just make the leftmost and rightmost ones mountains
            else
            {
                int[] position1 = {i,0};
                int[] position2 = {i,size-1};
                mountain = new ImpassableCell(borderData,0,position1);
                world[i,0] = mountain;

                mountain = new ImpassableCell(borderData,0,position2);
                world[i,size-1] = mountain;
            }
        } 
    }

    private void GenerateWorldInterior(int size)
    {
        //Note: this algorithm is exceedingly basic. Very likely that it 
        //  creates some wild spawning conditions

        for (int i = 1; i < size-1; i++)
        {
            for (int j = 1; j < size - 1; j++)
            {
                int spawnChance = random.Next(0,100);
                int[] position = {i,j};
                Cell intCell;

                //We want roughly 30% safe, 50% norm, 15% hostile, and 5% impassable chance per tile

                //Normal cell roll
                if (spawnChance <= 50)
                {
                    string[] normalTerrain = normalTerrainData.ImportFromFile(); //Maybe rewrite these as fileData?
                    intCell = new NormalCell(normalTerrain,position);
                }

                //Safe cell roll
                else if(spawnChance <= 80)
                {
                    string[] safeTerrain = safeTerrainData.ImportFromFile();
                    intCell = new SafeCell(safeTerrain,position);
                }

                //Hostile cell roll
                else if(spawnChance <= 90)
                {
                    string[] hostileTerrain = hostileTerrainData.ImportFromFile();
                    intCell = new HostileCell(hostileTerrain,position);
                }

                //Rest is impassible
                else
                {
                    string[] fileData = impassableTerrainData.ImportFromFile();
                    intCell = new ImpassableCell(fileData,position);
                }

                world[i,j] = intCell;
            }
        }
    }

    private void GenerateWorldSpawn()
    {
        //This overwrites the bottom left cell<?> with spawn
        int[] position = {1,1};
        Cell spawnCell = new SpawnCell(position);
        world[1,1] = spawnCell;
    }
}