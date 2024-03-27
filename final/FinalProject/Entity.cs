namespace Adventure_Qwest;
public class Entity
{
    ///////////////////////////////////////////////////////////////////////////
    // Class: Character
    //   Description: Base character class that contains information regarding
    //         the health, stats, inventory, equipment, and related functions
    ///////////////////////////////////////////////////////////////////////////
    
    protected int health;
    bool isAlive = true;
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
        health -= damage;
        if (health <= 0)
        {
            isAlive = false;
        }
    }
}