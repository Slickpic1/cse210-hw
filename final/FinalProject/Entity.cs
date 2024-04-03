using System.Collections.Generic;
using TextAnimation;
using Dice;

namespace Adventure_Qwest;
public class Entity  //make abstract?
{
    ///////////////////////////////////////////////////////////////////////////
    // Class: Character
    //   Description: Base character class that contains information regarding
    //         the health, stats, inventory, equipment, and related functions
    ///////////////////////////////////////////////////////////////////////////
    
    protected int maxHP;
    protected int HP;
    protected int AC;
    protected int ATK_bonus;
    protected bool canFlee;
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
    public bool IsAlive()
    {
        return isAlive;
    }
    public virtual string Action()
    {
        return "";
    }

    public virtual void Attack()
    {

    }
    public virtual int GetHP()  //maybe rename
    {
        return HP;
    }
    public virtual bool TakeDamage(int attack, int damage) //individual notifications for damage taken or not?
    {
        bool hit = false;

        //Check to see if attack hits
        if (attack >= AC)
        {
            HP -= damage;
            hit = true;
        }
        
        if (HP <= 0)
        {
            isAlive = false;  //need to display if the creature (or player) has died
        }
        return hit;
    }

    public virtual int AttackRoll()
    {   //Could put flavor text here for specific attacks
        return Dice.Dice.RollD20();
    }

    public virtual int DamageRoll()
    {
        return -1;
    }
}