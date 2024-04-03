namespace Adventure_Qwest;
public class TwigBlight:Monster
{
    public TwigBlight() : base()
    {
        
        //Define its name and type
        name = "twig blight";
        this.type = "plant";

        //Define its stats
        stats["str"] = 6;
        stats["dex"] = 13;
        stats["con"] = 12;
        stats["int"] = 4;
        stats["wis"] = 8;
        stats["cha"] = 3;

        //Define its basic stats
        this.HP = 4;
        this.XP = 25;
        this.AC = 13;
        this.ATTACK_WEIGHT = 100;
        //this.ACT_WEIGHT = 10;
    }

    public override int AttackRoll()
    {
        TextAnimation.Program.DisplaySlowString("The little blight tries to nite your ankles!");
        return base.AttackRoll() + 3;
    }

    public override int DamageRoll()
    {
        int damageRoll = Dice.Dice.RollD4();
        return damageRoll;
    }
}