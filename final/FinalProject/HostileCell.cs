public class HostileCell : Cell
{
    private List<List<string>> hostileTerrain = new List<List<string>>
    {
        //Format: type, description, mood, enemySpawnChance, treasureSpawnChance, enemyTypes
        new List<string>{"graveyard","rows and rows of decaying, crumbling headstones litter the dead, earthen landscape.","uneasy. Probably nothing. Maybe.","100","95","undead,fiend"},
        new List<string>{"old forest","ancient, gnarled trees covered in thick, dark leaves that create a canopy thick enough to occlude most light.","like you are being swallowed by the forest.","90","80","fey,beast,fiend"}
    };
    public HostileCell(int[] position) : base(position)
    {
        TERRAIN_INDEX = rand.Next(0,hostileTerrain.Count);
        terrainData = hostileTerrain[TERRAIN_INDEX];
        GenerateCell();
    }

    public override void GenerateCell()
    {
        base.GenerateCell();
        enemySpawnChance = int.Parse(terrainData[ENEMY_SPAWN_CHANCE_INDEX]);
        treasureSpawnChance = int.Parse(terrainData[TREASURE_SPAWN_CHANCE_INDEX]);
        string enemies = terrainData[ENEMY_TYPE_INDEX];
        ParseEnemiesString(enemies);
    }
}