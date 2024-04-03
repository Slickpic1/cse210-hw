namespace Adventure_Qwest;
public class Ghost : Monster
{
    //Ghost class will mostly be for fun, it won't do anything other than attempt to hit player (but fail) and then flee
    public Ghost() : base()
    {
        //Define its name and type
        name = "ghost";
        this.type = "undead";

        //Define its stats
        stats["str"] = 7;
        stats["dex"] = 13;
        stats["con"] = 10;
        stats["int"] = 10;
        stats["wis"] = 12;
        stats["cha"] = 17;

        //Define its basic stats
        this.HP = 25;   //these aren't real
        this.XP = 150;
        this.AC = 11;
        this.ATTACK_WEIGHT = 100;
    }

    public override int AttackRoll()
    {
        //Never hits
        TextAnimation.Program.DisplaySlowString("The ghost attempts to punch your face!");
        return 0;
    }

    public override int DamageRoll()
    {
        return 2*Dice.Dice.RollD6() + 3;
    }
}