using System.Collections.Generic;

namespace Adventure_Qwest;
public class Entity
{
    ///////////////////////////////////////////////////////////////////////////
    // Class: Character
    //   Description: Base character class that contains information regarding
    //         the health, stats, inventory, equipment, and related functions
    ///////////////////////////////////////////////////////////////////////////
    
    protected int HP;
    protected int AC;
    protected Dictionary<string,int> stats = new Dictionary<string, int>()
    {
        {"strength", 10},
        {"dexterity",10},
        {"constitution",10},
        {"intelligence",10},
        {"wisdom",10},
        {"charisma",10}
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

    public void TakeDamage(int damage)
    {
        HP -= damage;
        if (HP <= 0)
        {
            isAlive = false;
        }
    }
}