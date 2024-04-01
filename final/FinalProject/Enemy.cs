using System.Collections.Generic;
namespace Adventure_Qwest;
public class Enemy : Entity
{
    //private string type;  //implement later
    private string name;  
    private string enemyDescription;
    private Dictionary<string,string[]> monsterData = new Dictionary<string, string[]>();  //we can use this if we dont want to implement enemy types
    public Enemy(int[] position) : base(position)
    {
        
    }

    public string GetName()
    {
        return name;
    }
}