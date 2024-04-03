namespace Adventure_Qwest;
public class Bear: Monster
{
    public Bear() : base()
    {
        //Define its name and type
        name = "bear";
        this.type = "beast";

        //Define its stats
        stats["str"] = 19;
        stats["dex"] = 10;
        stats["con"] = 16;
        stats["int"] = 2;
        stats["wis"] = 13;
        stats["cha"] = 7;

        //Define its basic stats
        this.HP = 34;
        this.XP = 200;
        this.AC = 11;
        this.ATTACK_WEIGHT = 100;
        //this.ACT_WEIGHT = 50;   

    }

    public override int AttackRoll()
    {
        TextAnimation.Program.DisplaySlowString("The bear tries to bite you!");
        return base.AttackRoll() + (stats["str"]-10)/2 + 5;
    }

    public override int DamageRoll()
    {
        return Dice.Dice.RollD8() + 4;
    }
}