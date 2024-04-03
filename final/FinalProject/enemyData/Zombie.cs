namespace Adventure_Qwest;

public class Zombie : Monster
{
    public Zombie() : base()
    {
        CreateZombie();
    }
    public Zombie(int[] position) : base(position)
    {
        CreateZombie();
    }
    private void CreateZombie()
    {
        //Define its name and type
        name = "zombie";
        this.type = "undead";

        //Define its stats
        stats["str"] = 13;
        stats["dex"] = 6;
        stats["con"] = 16;
        stats["int"] = 3;
        stats["wis"] = 6;
        stats["cha"] = 5;

        //Define its basic stats
        this.HP = 22;
        this.XP = 50;
        this.AC = 8;
        this.ATTACK_WEIGHT = 100;   //will always attack
        
    }

    public override int AttackRoll()
    {
        int attack = Dice.Dice.RollD20() + (stats["str"]-10)/2;  
        TextAnimation.Program.DisplaySlowString("The zombie lunges at you!\n");
        return attack;
    }

    public override int DamageRoll()
    {
        int damage = Dice.Dice.RollD6() + 1;
        return damage;
    }
}