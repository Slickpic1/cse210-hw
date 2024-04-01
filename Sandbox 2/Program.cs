using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Console.WriteLine(int.Parse(2.5/2))
    }
}

public class Monster
{
    public int HP;
    public int AC;
    public string type;

}

public class Zombie : Monster
{
    public Zombie()
    {
        this.HP = 12;
        this.AC = 4;
        this.type = "undead";
    }
}
