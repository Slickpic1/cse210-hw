public class World
{
    private Cell[,] world;      //not sure if this is legal

    public World(string worldSize)
    {
        int size = 11;  //if not zero, returns error with below function (not sure why)

        switch (worldSize)  //Maybe default to small?
        {
            case "Small":
                size = 11;
                break;

            case "Medium":
                size = 21;
                break;
            
            case "Large":
                size = 31;
                break;
        }

        world = new Cell[size,size];
        //THIS CODE WORKS FOR terrainData file structure ONLY
        //Loop through the exterior points and turn them into mountains
        for (int i = 0; i < world.Length;i++)
        {
            if (i == 0 || i == world.Length-1)
            {
                for (int j = 0; i < world.Length; j++)
                {
                    
                }
            }
            
        } 

    }

    private void GenerateWorld()
    {


    }
}