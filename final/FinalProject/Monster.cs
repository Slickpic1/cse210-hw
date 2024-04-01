using System.Collections.Generic;
namespace Adventure_Qwest;
public class Monster : Entity
{
    //private string type;  //implement later
    protected string name;  
    protected string type;
    protected string description;
    protected int XP;
    public Monster(){}
    public Monster(int[] position) : base(position)
    {}

    public string GetName()
    {
        return name;
    }
}