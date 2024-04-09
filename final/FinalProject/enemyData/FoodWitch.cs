using System.Diagnostics;

namespace Adventure_Qwest;
public class FoodWitch : Monster
{
    public FoodWitch() : base()
    {
        //Define its name and type
        name = "food witch";
        this.type = "fay";

        //Define its stats
        stats["str"] = 10;
        stats["dex"] = 12;
        stats["con"] = 11;
        stats["int"] = 14;
        stats["wis"] = 15;
        stats["cha"] = 18;

        //Define its basic stats
        this.maxHP = 25;
        currentHP = maxHP;
        this.XP = 100;
        this.AC = 12;
        this.ATTACK_WEIGHT = 100;
    }

    public override int AttackRoll()
    {
        TextAnimation.Program.DisplaySlowString("The witch conjures a coconut and tries to throw it at you!\n");
        return base.AttackRoll() + 4;
    }

    public override int DamageRoll()
    {
        return Dice.Dice.RollD4() + 2;
    }

    public override void DisplayAggroMessage()
    {
        TextAnimation.Program.DisplaySlowString("You spot a pile ")
    }
}