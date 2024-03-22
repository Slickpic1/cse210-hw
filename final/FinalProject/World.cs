public class World
{
    public Cell[,] world;      //not sure if this is legal

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

        world = new Cell[size,size];   //Be careful here, im not sure how referencing and pointers work here
        GenerateWorldBorder(size);

    }

    private void GenerateWorldBorder(int size)
    {
        //Create a basic mountain type cell
        Cell mountain = new Cell(0);

        //Run along vertical axis
        for (int i = 0; i < size;i++)
        {
            //If top or bottom, fill every cell position with mountains
            if (i == 0 || i == size-1)
            {
                //Run through every horizontal position
                for (int j = 0; j < size; j++)
                {
                    world[i,j] = mountain;
                }
            }

            //Otherwise, just make the leftmost and rightmost ones mountains
            else
            {
                world[i,0] = mountain;
                world[i,size-1] = mountain;
            }
        } 
    }

    private void GenerateWorldInterior(int size)
    {
        
    }
}