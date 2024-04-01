namespace Adventure_Qwest;
public class NormalCell : Cell
{
    private List<List<string>> normalTerrain = new List<List<string>>
    {
        //Format: type, description, mood, enemySpawnChance, treasureSpawnChance, enemyTypes
        new List<string>{"forest","tall pine trees swaying in the gentle breeze.","like you are being watched. But probably not.","50","45","beasts,plants,fey"},
        new List<string>{"plains","rolling hills of tall, browning grass. The sun beats down on you.","like you miss your mom.","45","30","beasts,plants,humanoids"}
    };
    public NormalCell(int[] position) : base(position)
    {
        TERRAIN_INDEX = rand.Next(0,normalTerrain.Count);
        terrainData = normalTerrain[TERRAIN_INDEX];
        GenerateCell();
    }

    public override void GenerateCell()
    {
        enemySpawnChance = int.Parse(terrainData[ENEMY_SPAWN_CHANCE_INDEX]);
        treasureSpawnChance = int.Parse(terrainData[TREASURE_SPAWN_CHANCE_INDEX]);
        string enemies = terrainData[ENEMY_TYPE_INDEX];
        ParseEnemiesString(enemies); //breaks enemies into list of enemy types (might want to rename)
        base.GenerateCell();
    }
}