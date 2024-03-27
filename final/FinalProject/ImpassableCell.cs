namespace Adventure_Qwest;
public class ImpassableCell : Cell
{
    public ImpassableCell(string[] fileData, int[] position) : base(fileData,position)
    {
        impassable = true;
    }

    public ImpassableCell(string[] fileData, int terrainIndex, int[] position) : base(fileData,terrainIndex,position)
    {
        impassable = true;
    }
}