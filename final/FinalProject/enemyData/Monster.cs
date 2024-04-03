using System.Collections.Generic;
namespace Adventure_Qwest;
public class Monster : Entity
{
    //private string type;  //implement later
    protected string name;  
    protected string type;
    protected string description;

    // Weights for the different actions
    protected int ATTACK_WEIGHT;
    protected int ACT_WEIGHT;
    protected int USE_ITEM_WEIGHT;
    protected int XP;
    public Monster(){}
    public Monster(int[] position) : base(position)
    {}

    public override string Action()
    {
        //choose a random number
        Random rand = new Random();
        int actionChance = rand.Next(0,100);
        
        if (actionChance < ATTACK_WEIGHT)
        {
            return "attack";
        }
        else if(actionChance < ATTACK_WEIGHT + ACT_WEIGHT)
        {
            return "act";
        }
        else
        {
            return "use item";
        }
    }
    public string GetName()
    {
        return name;
    }
}