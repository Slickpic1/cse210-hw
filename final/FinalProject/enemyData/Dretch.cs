namespace Adventure_Qwest;
public class Dretch : Monster
{
    public Dretch() : base()
    {
        
        //Define its name and type
        name = "dretch";
        this.type = "fiend";

        //Define its stats
        stats["str"] = 11;
        stats["dex"] = 11;
        stats["con"] = 12;
        stats["int"] = 5;
        stats["wis"] = 8;
        stats["cha"] = 3;

        //Define its basic stats
        this.HP = 18;
        this.XP = 50;
        this.AC = 11;
        this.ATTACK_WEIGHT = 100;
        //this.ACT_WEIGHT = 20;
    }

    public override int AttackRoll()
    {
        TextAnimation.Program.DisplaySlowString("The small dretch attempts to slash at you with its claws!");
        return base.AttackRoll() + 2;
    }

    public override int DamageRoll()
    {
        return Dice.Dice.RollD6();
    }
}