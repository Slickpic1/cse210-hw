public class Character
{
    ///////////////////////////////////////////////////////////////////////////
    // Class: Character
    //   Description: Base character class that contains information regarding
    //         the health, stats, inventory, equipment, and related functions
    ///////////////////////////////////////////////////////////////////////////
    
    protected int health{get;}
    public int[] position = {0,0};  //Not sure how this get ought to work...
    protected List<Item> items = new List<Item>();
    //protected Weapon weapon = new Weapon(); Get later

    public Character(){}
    public Character(int[] position)
    {
        this.position = position;
    }
}