namespace Adventure_Qwest;
public class Goblin:Monster
{
    public Goblin() : base()
    {
        //Define its name and type
        name = "goblin";
        this.type = "humanoid";

        //Define its stats
        stats["str"] = 8;
        stats["dex"] = 14;
        stats["con"] = 10;
        stats["int"] = 10;
        stats["wis"] = 8;
        stats["cha"] = 8;

        //Define its basic stats
        this.maxHP = 7;
        currentHP = maxHP;
        this.XP = 50;
        this.AC = 15;
        this.ATTACK_WEIGHT = 100;
    }

    public override int AttackRoll()
    {
        TextAnimation.Program.DisplaySlowString("The wicked goblin tries to stab you!\n");
        return base.AttackRoll() + 4;
    }

    public override int DamageRoll()
    {
        return Dice.Dice.RollD6() + 2;
    }
}