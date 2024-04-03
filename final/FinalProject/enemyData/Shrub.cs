namespace Adventure_Qwest;
public class Shrub:Monster
{
    public Shrub() : base()
    {
        
        //Define its name and type
        name = "shrub";
        this.type = "plant";

        //Define its stats
        stats["str"] = 3;
        stats["dex"] = 8;
        stats["con"] = 11;
        stats["int"] = 3;
        stats["wis"] = 1;
        stats["cha"] = 17;

        //Define its basic stats
        this.HP = 20;
        this.XP = 10;
        this.AC = 9;
        this.ATTACK_WEIGHT = 100;
    }

    public override int AttackRoll()
    {
        //Bush can never hit you
        TextAnimation.Program.DisplaySlowString("You feel like the bush is trying to hit you, despite only being a bush.");
        return 0;
    }

    public override int DamageRoll()
    {
        return 0;
    }
}