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
        name = "zombie";
        stats["str"] = 13;
        stats["dex"] = 6;
        stats["con"] = 16;
        stats["int"] = 3;
        stats["wis"] = 6;
        stats["cha"] = 5;
        this.HP = 22;
        this.XP = 50;
        this.AC = 8;
        this.type = "undead";
    }

    public override int AttackRoll()
    {
        int attack = Dice.Dice.RollD20() + stats["str"]/2;
        return attack;
    }

    public override int DamageRoll()
    {
        int damage = Dice.Dice.RollD6() + 1;
        return damage;
    }
}