namespace Adventure_Qwest;
public class Enemy : Entity
{
    private string name;
    private string type;
    private List<List<string>> enemyData = new List<List<string>> //potentially change to dict or array of arrays if thats better
    {
        //General structure
        //{name,type,health,baseDamage,}  <- Need to restructure this for DnD style stats
        new List<string>{"goblin","7","5"},
        new List<string>{""}

    };

    public Enemy(int[] position) : base(position)
    {
        
    }
}