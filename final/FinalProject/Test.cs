namespace Adventure_Qwest;
public class Test
{
    public World testWorld;
    public Test()
    {
        Console.Clear();
        Program.GenerateWorld();
        testWorld = Program.gameWorld;  //does this do what i need it to? (y)
        TestCellDisplay();
        TestWorldGeneration();
        TestPlayerMovement();
        TestCombatLoop();
    }
    private void TestTxtFileReader()
    {
        TxtFileHandler txtFile = new TxtFileHandler();
    }
    private void TestCellDisplay()
    {
        int[] testPosition = {1,2};
        Cell testCell = new NormalCell(testPosition);
        testCell.DescribeCell();

        testCell.DescribeAdjacentCell("north");
    }

    private void TestPlayerMovement()
    {
        Player player = new Player();
        Console.WriteLine($"Player position: X:{player.position[1]}, Y:{player.position[0]}");
        Console.WriteLine($"Attempting to move to {testWorld.world[0,1].GetCellType()}");
        player.Move("south");
        Console.WriteLine($"New player position: X:{player.position[1]}, Y:{player.position[0]}");
        Console.WriteLine($"Attempting to move to {testWorld.world[2,1].GetCellType()}");
        player.Move("north");
        Console.WriteLine($"New player position: X:{player.position[1]}, Y:{player.position[0]}");
    }

    private void TestWorldGeneration()
    {
        //Run through our tests for world generation
        bool borderGenTest = TestBorderGeneration();
        bool interiorGenTest = TestInteriorWorldGen();
        bool spawnGenTest = TestSpawnWorldGen();
        //bool monsterSpawnTest = TestEnemySpawns();

        //Display Results  (Can we align this better?)
        Console.WriteLine();
        Console.WriteLine($"==============================================");
        Console.WriteLine($"World Generation Test Results:");
        Console.WriteLine($"==============================================");
        Console.WriteLine($"  Worldsize:        {testWorld.world.Length}");
        Console.WriteLine($"  Border Generation:         {borderGenTest}");
        Console.WriteLine($"  Interior Generation:       {interiorGenTest}");
        Console.WriteLine($"  Spawn Generation:          {spawnGenTest}");


     //.PadLeft(20)   <- this will right align code

    }
    private bool TestBorderGeneration()   //change back to string[]
    {
        //Test to see if border range generated correctly
        bool testPassed = true;
        string testType;

        int size = testWorld.GetSize();  //Backwards way of getting size, but good for now

        for (int i = 0; i < size;i++)
        {
            //Console.Write($"i = {i}");
            if (i == 0 || i == size-1)
            {
                for (int j = 0; j < size; j++)
                {
                    testType = testWorld.world[i,j].GetCellType();
                    if (testType != "mountain")
                    {
                        testPassed = false;
                    }
                }
            }
            else
            {
                testType = testWorld.world[i,0].GetCellType();
                if (testType != "mountain")
                {
                    testPassed = false;
                }
                testType = testWorld.world[i,size-1].GetCellType();
                if (testType != "mountain")
                {
                    testPassed = false;
                }
            }
        }
        //string[] returnString = new string[]{testName,borderGeneration};
        return testPassed;
    }

    private bool TestInteriorWorldGen()
    {
        int size = testWorld.GetSize();
        bool testPassed = true;                //need to implement this
        for (int i = 1; i < size-1; i++)
        {
            for (int j = 1; j < size - 1; j++)
            {
                Console.WriteLine(testWorld.world[i,j].GetCellType());
            }
        }
        return testPassed;
    }

    private bool TestSpawnWorldGen()
    {
        int size = testWorld.GetSize();
        bool testPassed = true;
        if (testWorld.world[1,1].GetCellType() != "spawn")
        {
            Console.WriteLine(testWorld.world[1,1].GetCellType());
            testPassed = false;
        }
        return testPassed;
    }

    private bool TestCombatLoop()
    {
        //Create new monster and player for combat loop
        Zombie zombie = new Zombie();
        Player player = new Player();

        //Run combat loop
        CombatLoop combatLoop = new CombatLoop(zombie);

        //This will only return if combat loop successfuly ends
        return true;
    }
}