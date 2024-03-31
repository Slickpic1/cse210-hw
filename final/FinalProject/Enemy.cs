namespace Adventure_Qwest;
public class Enemy : Entity
{
    //private string type;  //implement later
    private string name;  
    private string enemyDescription;
    public Enemy(int[] position) : base(position)
    {
        
    }

    public string GetName()
    {
        return name;
    }
}