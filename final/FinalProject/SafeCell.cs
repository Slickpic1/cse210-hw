namespace Adventure_Qwest;
public class SafeCell : Cell
{
    private List<List<string>> safeTerrain = new List<List<string>>
    {
        //format:type,description,mood,enemySpawnChance,treasureSpawnChance
        new List<string>{"meadow","lush, green grass inbetween tall oak trees.","like taking a rest below the trees.","0","2"}
    };
    public SafeCell(int[] position) : base(position)
    {
        //Choose a random 
        TERRAIN_INDEX = rand.Next(0,safeTerrain.Count);
        terrainData = safeTerrain[TERRAIN_INDEX];
        GenerateCell();
    }

    public override void GenerateCell()
    {
        base.GenerateCell();
        treasureSpawnChance = int.Parse(terrainData[TREASURE_SPAWN_CHANCE_INDEX]);
    }
}