using System.Collections.Generic;
using Dice;

namespace Adventure_Qwest;
public class Entity  //make abstract?
{
    ///////////////////////////////////////////////////////////////////////////
    // Class: Character
    //   Description: Base character class that contains information regarding
    //         the health, stats, inventory, equipment, and related functions
    ///////////////////////////////////////////////////////////////////////////
    
    protected int HP;
    protected int AC;
    protected int ATK_bonus;
    protected Dictionary<string,int> stats = new Dictionary<string, int>()
    {
        {"str",10},
        {"dex",10},
        {"con",10},
        {"int",10},
        {"wis",10},
        {"cha",10}
    };
    private bool isAlive = true;
    public int[] position = {0,0};  //initial position, inside of a mountain
    
    //Implement later//
    //protected List<Item> items = new List<Item>();
    //protected Weapon weapon = new Weapon(); Do this later

    public Entity(){}
    public Entity(int[] position)
    {
        this.position = position;
    }

    public virtual void TakeDamage(int attack, int damage)
    {
        //Check to see if attack hits
        if (attack >= AC)
        {
            HP -= damage;
        }
        
        if (HP <= 0)
        {
            isAlive = false;
        }
    }

    public virtual int AttackRoll()
    {
        return -1;
    }

    public virtual int DamageRoll()
    {
        return -1;
    }
}