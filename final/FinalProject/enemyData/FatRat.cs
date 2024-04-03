namespace Adventure_Qwest;
public class FatRat:Monster
{
    public FatRat() : base()
    {
        
        //Define its name and type
        name = "fat rat";
        this.type = "beast";

        //Define its stats
        stats["str"] = 6;
        stats["dex"] = 10;
        stats["con"] = 10;
        stats["int"] = 2;
        stats["wis"] = 10;
        stats["cha"] = 4;

        //Define its basic stats
        this.HP = 3;
        this.XP = 10;
        this.AC = 11;
        this.ATTACK_WEIGHT = 100;
        //this.ACT_WEIGHT = 30;
        this.canFlee = true;
    }

    public override int AttackRoll()
    {
        TextAnimation.Program.DisplaySlowString("The fat rat leaps in the air in attempt to bite your fingers!");
        return base.AttackRoll();
    }

    public override int DamageRoll()
    {
        return 2;
    }
}