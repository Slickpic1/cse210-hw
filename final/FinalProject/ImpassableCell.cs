public class ImpassableCell : Cell
{
    List<List<string>> impassableTerrain = new List<List<string>>
    {
        new List<string>{"mountain","rocky outcroppings that sprawl upwards beyond visions edge.","overwhelmed by the sheer size of the steep bluffs."}
    };

    public ImpassableCell(int[] position) : base(position)
    {
        impassable = true;
        TERRAIN_INDEX = rand.Next(0,impassableTerrain.Count);
        terrainData = impassableTerrain[TERRAIN_INDEX];
        GenerateCell();
    }

    public ImpassableCell(int TERRAIN_INDEX, int[] position) : base(TERRAIN_INDEX,position)
    {
        impassable = true;
        terrainData = impassableTerrain[TERRAIN_INDEX];
        GenerateCell();
    }
}